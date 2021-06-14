namespace Big_Boss
{
    partial class Задание6
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.Calculate = new System.Windows.Forms.Button();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(788, 386);
            this.zedGraph.TabIndex = 1;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(806, 12);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(168, 69);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Ответ";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(930, 89);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(20, 20);
            this.TextBoxY.TabIndex = 7;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(865, 90);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(20, 20);
            this.TextBoxX.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(829, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "y (    ) =";
            // 
            // Задание6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 411);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.zedGraph);
            this.Name = "Задание6";
            this.Text = "Задание 6(1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.Label label1;
    }
}