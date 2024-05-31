using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static translate.Form1;
using translate.error_word;
using translate.new_word;
using translate.eng_word;

namespace translate.Classes
{
    class Translation
    {
        public static string Translate(string text, int inputLangIndex = 1, int outputLangIndex = 0, bool addWord = false)
        {
            List<Dictionary<string, string>> languages = new List<Dictionary<string, string>>();
            foreach (string path in FilePaths)
            {
                Dictionary<string, string> file = WithJson.ReadJsonFile(path);
                languages.Add(file);
            }
            /*Dictionary<int, string> engWords = WithJson.ReadJsonFile(FIlePathEng);
            Dictionary<int, string> ruWords = WithJson.ReadJsonFile(FIlePathRu);
            Dictionary<int, string> frWords = WithJson.ReadJsonFile(FIlePathFr);
            Dictionary<int, string>[] languages = { engWords, ruWords, frWords };*/

            bool ifFilesExists(object[] filepaths)
            {
                bool check = true;
                foreach (string el in filepaths)
                {
                    check = check && File.Exists(el);
                }

                return check;
            }

            string index = "";

            if (ifFilesExists(FilePaths))
            {
                try
                {
                    //Если Ввод содержит значение text
                    if (languages.ElementAt(inputLangIndex).ContainsValue(text.ToLower()))
                    {
                        //Для каждого эл-та Ввода
                        foreach (var el in languages.ElementAt(inputLangIndex))
                        {
                            //Если Значение == text
                            if (el.Value == text.ToLower())
                            {
                                index = el.Key;
                            }
                        }
                        //Если Ключ пустой || Вывод НЕ содержит Ключ
                        if (index == "" || !languages.ElementAt(outputLangIndex).ContainsKey(index))
                        {
                            FormErrorWord formErr = new FormErrorWord();
                            formErr.Show();
                            return text = "";
                        }
                        else
                        {
                            return languages.ElementAt(outputLangIndex)[index];
                        }
                        //return languages[outputLangIndex][index];
                    }
                    else if (addWord)
                    {
                        FormEngWord formEngWord = new FormEngWord();
                        formEngWord.ShowDialog();
                        WithJson.TextToJson(formEngWord.Texts, FilePaths.ElementAt(Array.IndexOf(FileNames, "Английский")).ToString());
                        return formEngWord.Texts;
                    }
                    else
                    {
                        FormErrorWord formErr = new FormErrorWord();
                        formErr.Show();
                        return text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при разборе файла: " + ex.Message);
                    return text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Один или несколько файлов не найдено");
                return text = "";
            }
        }
    }
}
