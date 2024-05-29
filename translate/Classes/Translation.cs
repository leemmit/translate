using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static translate.Form1;
using translate.error_word;

namespace translate.Classes
{
    class Translation
    {
        public static string Translate(string text, int inputLangIndex = 1, int outputLangIndex = 0)
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
                    if (languages.ElementAt(inputLangIndex).ContainsValue(text.ToLower()))
                    //if (languages[inputLangIndex].ContainsValue(text.ToLower()))
                    {
                        foreach (var el in languages.ElementAt(inputLangIndex))
                        {
                            if (el.Value == text.ToLower())
                            {
                                index = el.Key;
                            }
                        }
                        if (index == "")
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
