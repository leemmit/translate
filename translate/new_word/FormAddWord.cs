using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using translate.Classes;
using translate;
using Newtonsoft.Json;


namespace translate.new_word
{
    public partial class FormAddWord : Form
    {

        public FormAddWord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            fa_tb_eng.Multiline = false;
            fa_tb_ru.Multiline = false;
            fa_tb_fr.Multiline = false;
            SetText();
        }

        private void SetText()
        {
            TextBox[] tb_array = { fa_tb_eng, fa_tb_ru, fa_tb_fr };
            tb_array[Form1.SelectedInput].Text = Form1.TextBoxInput.Text;
        }

        private void fa_btn_add_Click(object sender, EventArgs e)
        {
            if (fa_tb_eng.Text != "" && fa_tb_ru.Text != "" && fa_tb_fr.Text != "")
            {
                WithJson.TextToJson(fa_tb_eng.Text, Form1.FIlePathEng);
                WithJson.TextToJson(fa_tb_ru.Text, Form1.FIlePathRu);
                WithJson.TextToJson(fa_tb_fr.Text, Form1.FIlePathFr);
                MessageBox.Show("Данные успешно сохранены в файл.");
            }
            else
            {
                MessageBox.Show("Значения введены некорректно. Пожалуйста, проверьте правильность ввода и попробуйте еще раз");
            }
            Close();
        }

        
    }
}
