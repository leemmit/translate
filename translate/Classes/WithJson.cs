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
        public static Dictionary<int, string> ReadJsonFile(string filePath)
        {
            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Чтение файла JSON
            string json = File.ReadAllText(filePath, Encoding.UTF8);

            // Десериализация JSON в словарь
            Dictionary<int, string> jsonObject = JsonConvert.DeserializeObject<Dictionary<int, string>>(json);

            return jsonObject;
        }

        public static void TextToJson(string text, string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath, System.Text.Encoding.UTF8);

                var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                int maxKey = data.Keys.Select(k => int.Parse(k)).Max();

                string newKey = (maxKey + 1).ToString();
                data.Add(newKey, text);

                string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);

                File.WriteAllText(filePath, updatedJson, System.Text.Encoding.UTF8);

                MessageBox.Show("Данные успешно сохранены в файл JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файл JSON: {ex.Message}");
            }
        }
    }
}
