namespace Big_Boss
{
    partial class Задание1
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_xy = new System.Windows.Forms.ComboBox();
            this.textBox_xy = new System.Windows.Forms.TextBox();
            this.button_gr = new System.Windows.Forms.Button();
            this.zMain = new ZedGraph.ZedGraphControl();
            this.textBox_lpy = new System.Windows.Forms.TextBox();
            this.textBox_lpx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_xy = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "y =";
            this.label2.Visible = false;
            // 
            // comboBox_xy
            // 
            this.comboBox_xy.FormattingEnabled = true;
            this.comboBox_xy.Items.AddRange(new object[] {
            "Ввести значения x",
            "Ввести значения y"});
            this.comboBox_xy.Location = new System.Drawing.Point(16, 123);
            this.comboBox_xy.Name = "comboBox_xy";
            this.comboBox_xy.Size = new System.Drawing.Size(102, 21);
            this.comboBox_xy.TabIndex = 41;
            this.comboBox_xy.Visible = false;
            // 
            // textBox_xy
            // 
            this.textBox_xy.Location = new System.Drawing.Point(18, 152);
            this.textBox_xy.Name = "textBox_xy";
            this.textBox_xy.Size = new System.Drawing.Size(181, 20);
            this.textBox_xy.TabIndex = 40;
            this.textBox_xy.Visible = false;
            // 
            // button_gr
            // 
            this.button_gr.Location = new System.Drawing.Point(7, 335);
            this.button_gr.Name = "button_gr";
            this.button_gr.Size = new System.Drawing.Size(230, 105);
            this.button_gr.TabIndex = 39;
            this.button_gr.Text = "Построить график";
            this.button_gr.UseVisualStyleBackColor = true;
            this.button_gr.Visible = false;
            this.button_gr.Click += new System.EventHandler(this.button_gr_Click);
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(243, 11);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(551, 429);
            this.zMain.TabIndex = 38;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // textBox_lpy
            // 
            this.textBox_lpy.Location = new System.Drawing.Point(56, 306);
            this.textBox_lpy.Name = "textBox_lpy";
            this.textBox_lpy.ReadOnly = true;
            this.textBox_lpy.Size = new System.Drawing.Size(100, 20);
            this.textBox_lpy.TabIndex = 37;
            this.textBox_lpy.Visible = false;
            // 
            // textBox_lpx
            // 
            this.textBox_lpx.Location = new System.Drawing.Point(56, 283);
            this.textBox_lpx.Name = "textBox_lpx";
            this.textBox_lpx.Size = new System.Drawing.Size(100, 20);
            this.textBox_lpx.TabIndex = 36;
            this.textBox_lpx.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "x =";
            this.label1.Visible = false;
            // 
            // label_xy
            // 
            this.label_xy.AutoSize = true;
            this.label_xy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_xy.Location = new System.Drawing.Point(14, 89);
            this.label_xy.Name = "label_xy";
            this.label_xy.Size = new System.Drawing.Size(204, 20);
            this.label_xy.TabIndex = 33;
            this.label_xy.Text = "Введите значение x and y";
            this.label_xy.Visible = false;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(18, 45);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 32;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_n.Location = new System.Drawing.Point(14, 11);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(182, 20);
            this.label_n.TabIndex = 31;
            this.label_n.Text = "Введите кол-во точек:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Задание1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_xy);
            this.Controls.Add(this.textBox_xy);
            this.Controls.Add(this.button_gr);
            this.Controls.Add(this.zMain);
            this.Controls.Add(this.textBox_lpy);
            this.Controls.Add(this.textBox_lpx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_xy);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label_n);
            this.Name = "Задание1";
            this.Text = "Задание1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_xy;
        private System.Windows.Forms.TextBox textBox_xy;
        private System.Windows.Forms.Button button_gr;
        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.TextBox textBox_lpy;
        private System.Windows.Forms.TextBox textBox_lpx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_xy;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}