using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Boss
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание1 newForm = new Задание1();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание2 newForm = new Задание2();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Задание3 newForm = new Задание3();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Laba4 newForm = new Laba4();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Задание7 newForm = new Задание7();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Задание6 newForm = new Задание6();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ДопЗадание3 newForm = new ДопЗадание3();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
