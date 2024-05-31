using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;


namespace translate.Classes
{
    class WithJson
    {
        public static Dictionary<string, string> ReadJsonFile(string filePath)
        {
            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Чтение файла JSON
            string json = File.ReadAllText(filePath, Encoding.UTF8);

            // Десериализация JSON в словарь
            Dictionary<string, string> jsonObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            return jsonObject;
        }

        public static void TextToJson(string text, string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath, System.Text.Encoding.UTF8);

                var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                //int maxKey = data.Keys.Select(k => int.Parse(k)).Max();

                string newKey = "";
                try
                {
                    if (filePath.Contains("Английский"))
                    {
                        newKey = text;
                    }
                    else
                    {
                        List<Dictionary<string, string>> languages = new List<Dictionary<string, string>>();
                        foreach (string path in Form1.FilePaths)
                        {
                            Dictionary<string, string> file = WithJson.ReadJsonFile(path);
                            languages.Add(file);
                        }
                        if (languages[Array.IndexOf(Form1.FileNames, "Английский")].ContainsKey(text))
                        {
                            
                        }
                        //newKey = Translation.Translate(text, Form1.ComboBoxOutput.SelectedIndex, Array.IndexOf(Form1.FileNames, "Английский"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обнаружении файла Английского языка: {ex.Message}\nПожалуйста проверьте что ваш файл существует и имеет название \"Английский\"");
                    return;
                }

                if (!data.ContainsKey(newKey))
                {
                    data.Add(newKey, text);

                    string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);

                    File.WriteAllText(filePath, updatedJson, System.Text.Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файл JSON: {ex.Message}");
            }
        }

        public static string ChooseFile()
        {
            string selectedFilePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл словаря";
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                }
            }
            return selectedFilePath;
        }
    }
}
