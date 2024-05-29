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
            fa_tb_from.Multiline = false;
            fa_tb_to.Multiline = false;
            SetText();
        }

        private void Init()
        {
            /*fa_cb_from.Items.Add(GetWbNames());
            fa_cb_to.Items.Add(GetWbNames(Form1.Wordbooks));*/
        }
        static string[] GetWbNames(Wordbook[] wordbooks)
        {
            string[] wbNames = { };
            foreach (Wordbook el in wordbooks)
            {
                wbNames.Append(el.Name);
            }
            return wbNames;
        }

        private void SetText()
        {
            TextBox[] tb_array = { fa_tb_from, fa_tb_to};
            tb_array[Form1.SelectedInput].Text = Form1.TextBoxInput.Text;
        }

        private void fa_btn_add_Click(object sender, EventArgs e)
        {
            //foreach (el in tb_array) 
            if (fa_tb_from.Text != "" && fa_tb_to.Text != "")
            {
                WithJson.TextToJson(fa_tb_from.Text, Form1.FIlePathEng);
                WithJson.TextToJson(fa_tb_to.Text, Form1.FIlePathRu);
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
