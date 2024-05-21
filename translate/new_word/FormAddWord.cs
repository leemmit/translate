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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fa_btn_add_Click(object sender, EventArgs e)
        {
            if (fa_tb_eng.Text != "" && fa_tb_ru.Text != "" && fa_tb_fr.Text != "")
            {
                WithJson.TextToJson(fa_tb_eng.Text, Form1.FIlePathEng);
                WithJson.TextToJson(fa_tb_ru.Text, Form1.FIlePathRu);
                WithJson.TextToJson(fa_tb_fr.Text, Form1.FIlePathFr);
            }
            else
            {
                MessageBox.Show("Значения введены некорректно. Пожалуйста, проверьте правильность ввода и попробуйте еще раз");
            }
        }

        
    }
}
