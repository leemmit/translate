﻿
namespace translate.new_word
{
    partial class FormAddWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fa_tb_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fa_btn_add = new System.Windows.Forms.Button();
            this.fa_tb_to = new System.Windows.Forms.TextBox();
            this.fa_cb_from = new System.Windows.Forms.ComboBox();
            this.fa_cb_to = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новое слово";
            // 
            // fa_tb_from
            // 
            this.fa_tb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fa_tb_from.Location = new System.Drawing.Point(40, 114);
            this.fa_tb_from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_tb_from.Multiline = true;
            this.fa_tb_from.Name = "fa_tb_from";
            this.fa_tb_from.Size = new System.Drawing.Size(191, 27);
            this.fa_tb_from.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите слово в соответствующих полях";
            // 
            // fa_btn_add
            // 
            this.fa_btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fa_btn_add.Location = new System.Drawing.Point(211, 157);
            this.fa_btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_btn_add.Name = "fa_btn_add";
            this.fa_btn_add.Size = new System.Drawing.Size(90, 33);
            this.fa_btn_add.TabIndex = 6;
            this.fa_btn_add.Text = "Добавить";
            this.fa_btn_add.UseVisualStyleBackColor = true;
            this.fa_btn_add.Click += new System.EventHandler(this.fa_btn_add_Click);
            // 
            // fa_tb_to
            // 
            this.fa_tb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fa_tb_to.Location = new System.Drawing.Point(281, 114);
            this.fa_tb_to.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_tb_to.Multiline = true;
            this.fa_tb_to.Name = "fa_tb_to";
            this.fa_tb_to.Size = new System.Drawing.Size(191, 27);
            this.fa_tb_to.TabIndex = 7;
            // 
            // fa_cb_from
            // 
            this.fa_cb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fa_cb_from.FormattingEnabled = true;
            this.fa_cb_from.Location = new System.Drawing.Point(40, 79);
            this.fa_cb_from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_cb_from.Name = "fa_cb_from";
            this.fa_cb_from.Size = new System.Drawing.Size(191, 28);
            this.fa_cb_from.TabIndex = 8;
            // 
            // fa_cb_to
            // 
            this.fa_cb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fa_cb_to.FormattingEnabled = true;
            this.fa_cb_to.Location = new System.Drawing.Point(281, 79);
            this.fa_cb_to.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_cb_to.Name = "fa_cb_to";
            this.fa_cb_to.Size = new System.Drawing.Size(191, 28);
            this.fa_cb_to.TabIndex = 9;
            // 
            // FormAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 201);
            this.Controls.Add(this.fa_cb_to);
            this.Controls.Add(this.fa_cb_from);
            this.Controls.Add(this.fa_tb_to);
            this.Controls.Add(this.fa_btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fa_tb_from);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fa_tb_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fa_btn_add;
        private System.Windows.Forms.TextBox fa_tb_to;
        private System.Windows.Forms.ComboBox fa_cb_from;
        private System.Windows.Forms.ComboBox fa_cb_to;
    }
}