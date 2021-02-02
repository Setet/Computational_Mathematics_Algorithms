namespace Big_Boss
{
    partial class Laba4
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
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(9, 38);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(332, 213);
            this.Answer.TabIndex = 0;
            this.Answer.Text = "";
            this.Answer.TextChanged += new System.EventHandler(this.Answer_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 107);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reader
            // 
            this.Reader.Location = new System.Drawing.Point(16, 12);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(124, 20);
            this.Reader.TabIndex = 5;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(146, 12);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(75, 20);
            this.txt.TabIndex = 6;
            this.txt.Text = ".txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // Laba4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 258);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer);
            this.Name = "Laba4";
            this.Text = "Laba4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Reader;
        private System.Windows.Forms.Button txt;
    }
}