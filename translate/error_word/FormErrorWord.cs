using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using translate.new_word;

namespace translate.error_word
{
    public partial class FormErrorWord : Form
    {
        public FormErrorWord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        private void fe_btn_add_Click(object sender, EventArgs e)
        {
            FormAddWord formAdd = new FormAddWord();
            formAdd.Show();
            Close();
            //formAdd.SetText();
        }

        private void fe_btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
