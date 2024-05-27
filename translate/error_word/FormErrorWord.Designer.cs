
namespace translate.error_word
{
    partial class FormErrorWord
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
            this.label2 = new System.Windows.Forms.Label();
            this.fe_btn_add = new System.Windows.Forms.Button();
            this.fe_btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка не найдена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить в словарь новое слово?";
            // 
            // fe_btn_add
            // 
            this.fe_btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fe_btn_add.Location = new System.Drawing.Point(43, 148);
            this.fe_btn_add.Name = "fe_btn_add";
            this.fe_btn_add.Size = new System.Drawing.Size(135, 51);
            this.fe_btn_add.TabIndex = 7;
            this.fe_btn_add.Text = "Добавить";
            this.fe_btn_add.UseVisualStyleBackColor = true;
            this.fe_btn_add.Click += new System.EventHandler(this.fe_btn_add_Click);
            // 
            // fe_btn_cancel
            // 
            this.fe_btn_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fe_btn_cancel.Location = new System.Drawing.Point(253, 148);
            this.fe_btn_cancel.Name = "fe_btn_cancel";
            this.fe_btn_cancel.Size = new System.Drawing.Size(135, 51);
            this.fe_btn_cancel.TabIndex = 8;
            this.fe_btn_cancel.Text = "Отмена";
            this.fe_btn_cancel.UseVisualStyleBackColor = true;
            this.fe_btn_cancel.Click += new System.EventHandler(this.fe_btn_cancel_Click);
            // 
            // FormErrorWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 222);
            this.Controls.Add(this.fe_btn_cancel);
            this.Controls.Add(this.fe_btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormErrorWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormErrorWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fe_btn_add;
        private System.Windows.Forms.Button fe_btn_cancel;
    }
}