namespace Big_Boss
{
    partial class Задание2
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
            this.textBoxEps = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zMain = new ZedGraph.ZedGraphControl();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEps
            // 
            this.textBoxEps.Location = new System.Drawing.Point(31, 64);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(100, 20);
            this.textBoxEps.TabIndex = 16;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(31, 37);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(31, 10);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Eps =";
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(233, 10);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(622, 365);
            this.zMain.TabIndex = 20;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(11, 89);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(156, 59);
            this.buttonCreate.TabIndex = 21;
            this.buttonCreate.Text = "Построить ";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Метод прямоугольников",
            "Метод Симпсона"});
            this.comboBox.Location = new System.Drawing.Point(11, 174);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(156, 21);
            this.comboBox.TabIndex = 28;
            this.comboBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Выберете способы решения";
            this.label4.Visible = false;
            // 
            // buttonNice
            // 
            this.buttonNice.Location = new System.Drawing.Point(11, 200);
            this.buttonNice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNice.Name = "buttonNice";
            this.buttonNice.Size = new System.Drawing.Size(156, 23);
            this.buttonNice.TabIndex = 30;
            this.buttonNice.Text = "Выбрать";
            this.buttonNice.UseVisualStyleBackColor = true;
            this.buttonNice.Visible = false;
            this.buttonNice.Click += new System.EventHandler(this.buttonNice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 31;
            // 
            // Laba2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.zMain);
            this.Controls.Add(this.textBoxEps);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Laba2";
            this.Text = "Laba2";
            this.Load += new System.EventHandler(this.Laba2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEps;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNice;
        private System.Windows.Forms.Label label5;
    }
}