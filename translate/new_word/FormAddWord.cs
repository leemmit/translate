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
        private static ComboBox _fa_cb_from;
        private static ComboBox _fa_cb_to;
        public static ComboBox Fa_Cb_From { get => _fa_cb_from; set => _fa_cb_from = value; }
        public static ComboBox Fa_Cb_To { get => _fa_cb_to; set => _fa_cb_to = value; }

        public FormAddWord()
        {
            InitializeComponent();
            InitVariables();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            fa_tb_from.Multiline = false;
            fa_tb_to.Multiline = false;
            RefreshFaCb();
            SetText();
        }

        private void SetText()
        {
            fa_cb_from.SelectedIndex = Math.Abs(Form1.ComboBoxInput.SelectedIndex);
            fa_cb_to.SelectedIndex = Form1.ComboBoxOutput.SelectedIndex;
            fa_tb_from.Text = Form1.TextBoxInput.Text;
        }

        private static void RefreshFaCb()
        {
            Fa_Cb_From.Items.Clear();
            Fa_Cb_To.Items.Clear();
            Fa_Cb_From.Items.AddRange(Form1.FileNames);
            Fa_Cb_To.Items.AddRange(Form1.FileNames);
        }

        private void InitVariables()
        {
            _fa_cb_from = fa_cb_from;
            _fa_cb_to = fa_cb_to;
        }

        private void fa_btn_add_Click(object sender, EventArgs e)
        {
            //foreach (el in tb_array) 
            if (fa_tb_from.Text != "" && fa_tb_to.Text != "")
            {
                WithJson.TextToJson(fa_tb_from.Text.ToLower(), Form1.FilePaths.ElementAt(fa_cb_from.SelectedIndex).ToString());
                WithJson.TextToJson(fa_tb_to.Text.ToLower(), Form1.FilePaths.ElementAt(fa_cb_to.SelectedIndex).ToString());
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
