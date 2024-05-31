using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using translate;
using translate.new_word;

namespace translate.eng_word
{
    public partial class FormEngWord : Form
    {
        private string _text;
        public string Texts { get => _text; set => _text = value; }
        public FormEngWord()
        {
            InitializeComponent();
            fen_outword.Text = Form1.TextBoxInput.Text; ;
        }

        private void fen_btn_Click(object sender, EventArgs e)
        {
            if (!(fen_tb.Text == ""))
            {
                Texts = fen_tb.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значение");
            }
        }
    }
}
