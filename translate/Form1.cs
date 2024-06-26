﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Globalization;
using translate.new_word;
using translate.Classes;

namespace translate
{
    public partial class Form1 : Form
    {
        private static NotifyIcon _notifyIcon;
        public static NotifyIcon NotifyIcon { get => _notifyIcon; set => _notifyIcon = value; }

        private static ComboBox _comboBoxInput;
        private static ComboBox _comboBoxOutput;
        private static TextBox _textBoxInput;
        private static TextBox _textBoxOutput;
        public static ComboBox ComboBoxInput { get => _comboBoxInput; set => _comboBoxInput = value; }
        public static ComboBox ComboBoxOutput { get => _comboBoxOutput; set => _comboBoxOutput = value; }
        public static TextBox TextBoxInput { get => _textBoxInput; set => _textBoxInput = value; }
        public static TextBox TextBoxOutput { get => _textBoxOutput; set => _textBoxOutput = value; }

        //private static Wordbook[] wordbooks = { };
        //public static Wordbook[] Wordbooks { get => wordbooks; set => wordbooks = value; }

        private static string[] filePaths = { };
        private string[] fileNames = { };
        public static string[] FilePaths { get => filePaths; set => filePaths = value; }

/*        static string filePathEng = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "eng_words.json");
        static string filePathRu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "russian_words.json");
        static string filePathFr = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "fr_words.json");*/
/*        public static string FIlePathEng { get => filePathEng; set => filePathEng = value; }
        public static string FIlePathRu { get => filePathRu; set => filePathRu = value; }
        public static string FIlePathFr { get => filePathFr; set => filePathFr = value; }*/

        private static int _selectedInput;
        public static int SelectedInput { get => _selectedInput; set => _selectedInput = value; }


        public Form1()
        {
            
            InitializeComponent();
            InitVariables();
            //InitWordbooks();
            Show();
            Activate();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            TextBoxOutput.Text = Translation.Translate(tb_input.Text, cb_input.SelectedIndex, cb_output.SelectedIndex);
        }

        private void btn_addWord_Click(object sender, EventArgs e)
        {
            FormAddWord formAdd = new FormAddWord();
            formAdd.Show();
        }

        private void btn_addList_Click(object sender, EventArgs e)
        {
            WithJson.ChooseFile();
        }

        private void InitVariables()
        {
            Wordbook[] wordbooks = { };
            MaximizeBox = false;

            cb_input.SelectedIndex = 1;
            cb_output.SelectedIndex = 0;
            tb_output.ReadOnly = true;
            tb_output.BackColor = Color.White;

            _notifyIcon = notifyIcon;
            _comboBoxInput = cb_input;
            _comboBoxOutput = cb_output;
            _textBoxInput = tb_input;
            _textBoxOutput = tb_output;

            SelectedInput = cb_input.SelectedIndex;
        }

        public static string[] InitDictionaries()
        {
            MessageBox.Show("Выберите путь к папке словарей");
            string[] files = { };
            FolderBrowserDialog choooseFolder = new FolderBrowserDialog();
            choooseFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            choooseFolder.SelectedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            DialogResult result = choooseFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFolder = choooseFolder.SelectedPath;
                //string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON");

                files = Directory.GetFiles(selectedFolder);
            }
            return files;
        }

/*        private void InitWordbooks()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON");

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                filePaths.Append(file);
            }

            //WithJson.TextToJson( , Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionaries.json"));
        }*/

        public bool CheckPaths(string[] paths)
        {
            bool check = true;
            foreach (string el in paths)
            {
                check = check && (el != "");
            }
            return check;
        }

/*        private void InitWordbooks(Wordbook[] wordbooks)
        {
            wordbooks.Append(new Wordbook("English", FIlePathEng));
            wordbooks.Append(new Wordbook("Русский", FIlePathRu));
            wordbooks.Append(new Wordbook("French", FIlePathFr));
        }*/

        private void cb_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_input.Text = Translation.Translate(tb_output.Text, cb_output.SelectedIndex, cb_input.SelectedIndex);
        }

        private void cb_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_output.Text = Translation.Translate(tb_input.Text, cb_input.SelectedIndex, cb_output.SelectedIndex);
        }
    }
}

