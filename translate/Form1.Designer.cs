
namespace translate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.cb_input = new System.Windows.Forms.ComboBox();
            this.cb_output = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_translate = new System.Windows.Forms.Button();
            this.btn_addWord = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_addList = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_input.Location = new System.Drawing.Point(71, 167);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(311, 262);
            this.tb_input.TabIndex = 0;
            // 
            // tb_output
            // 
            this.tb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_output.Location = new System.Drawing.Point(496, 167);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(305, 262);
            this.tb_output.TabIndex = 1;
            // 
            // cb_input
            // 
            this.cb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_input.FormattingEnabled = true;
            this.cb_input.Items.AddRange(new object[] {
            "Английский",
            "Русский",
            "Французский"});
            this.cb_input.Location = new System.Drawing.Point(71, 87);
            this.cb_input.Name = "cb_input";
            this.cb_input.Size = new System.Drawing.Size(185, 37);
            this.cb_input.TabIndex = 2;
            this.cb_input.SelectionChangeCommitted += new System.EventHandler(this.cb_input_SelectedIndexChanged);
            // 
            // cb_output
            // 
            this.cb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_output.FormattingEnabled = true;
            this.cb_output.Items.AddRange(new object[] {
            "Английский",
            "Русский",
            "Французский"});
            this.cb_output.Location = new System.Drawing.Point(616, 87);
            this.cb_output.Name = "cb_output";
            this.cb_output.Size = new System.Drawing.Size(185, 37);
            this.cb_output.TabIndex = 3;
            this.cb_output.SelectionChangeCommitted += new System.EventHandler(this.cb_output_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Переводчик";
            // 
            // btn_translate
            // 
            this.btn_translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_translate.Image = global::translate.Properties.Resources._32;
            this.btn_translate.Location = new System.Drawing.Point(391, 76);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(94, 68);
            this.btn_translate.TabIndex = 4;
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btn_addWord
            // 
            this.btn_addWord.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_addWord.Location = new System.Drawing.Point(584, 448);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(217, 62);
            this.btn_addWord.TabIndex = 7;
            this.btn_addWord.Text = "Добавить слово";
            this.btn_addWord.UseVisualStyleBackColor = true;
            this.btn_addWord.Click += new System.EventHandler(this.btn_addWord_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btn_addList
            // 
            this.btn_addList.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_addList.Location = new System.Drawing.Point(71, 448);
            this.btn_addList.Name = "btn_addList";
            this.btn_addList.Size = new System.Drawing.Size(232, 62);
            this.btn_addList.TabIndex = 8;
            this.btn_addList.Text = "Добавить словарь";
            this.btn_addList.UseVisualStyleBackColor = true;
            this.btn_addList.Click += new System.EventHandler(this.btn_addList_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 533);
            this.Controls.Add(this.btn_addList);
            this.Controls.Add(this.btn_addWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.cb_output);
            this.Controls.Add(this.cb_input);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.ComboBox cb_input;
        private System.Windows.Forms.ComboBox cb_output;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btn_addList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

