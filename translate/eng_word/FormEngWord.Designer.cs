
namespace translate.eng_word
{
    partial class FormEngWord
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
            this.fen_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fen_outword = new System.Windows.Forms.Label();
            this.fen_tb = new System.Windows.Forms.TextBox();
            this.fen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fen_title
            // 
            this.fen_title.AutoSize = true;
            this.fen_title.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fen_title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fen_title.Location = new System.Drawing.Point(46, 9);
            this.fen_title.Name = "fen_title";
            this.fen_title.Size = new System.Drawing.Size(342, 114);
            this.fen_title.TabIndex = 1;
            this.fen_title.Text = "Пожалуйста, введите \r\nперевод Вашего слова \r\nна английский язык";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введено слово:";
            // 
            // fen_outword
            // 
            this.fen_outword.AutoSize = true;
            this.fen_outword.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fen_outword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fen_outword.Location = new System.Drawing.Point(188, 139);
            this.fen_outword.Name = "fen_outword";
            this.fen_outword.Size = new System.Drawing.Size(0, 38);
            this.fen_outword.TabIndex = 4;
            // 
            // fen_tb
            // 
            this.fen_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fen_tb.Location = new System.Drawing.Point(19, 186);
            this.fen_tb.Multiline = true;
            this.fen_tb.Name = "fen_tb";
            this.fen_tb.Size = new System.Drawing.Size(390, 39);
            this.fen_tb.TabIndex = 5;
            // 
            // fen_btn
            // 
            this.fen_btn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fen_btn.Location = new System.Drawing.Point(141, 246);
            this.fen_btn.Name = "fen_btn";
            this.fen_btn.Size = new System.Drawing.Size(135, 51);
            this.fen_btn.TabIndex = 7;
            this.fen_btn.Text = "Принять";
            this.fen_btn.UseVisualStyleBackColor = true;
            this.fen_btn.Click += new System.EventHandler(this.fen_btn_Click);
            // 
            // FormEngWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 313);
            this.Controls.Add(this.fen_btn);
            this.Controls.Add(this.fen_tb);
            this.Controls.Add(this.fen_outword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fen_title);
            this.Name = "FormEngWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fen_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fen_outword;
        private System.Windows.Forms.TextBox fen_tb;
        private System.Windows.Forms.Button fen_btn;
    }
}