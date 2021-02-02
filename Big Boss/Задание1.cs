using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Big_Boss
{
    public partial class Задание1 : Form
    {
        public Задание1()
        {
            InitializeComponent();
        }
        GraphPane pane;
        double[] mas_y;
        double[] mas_x;
        public int n;

        public double lp(double[] x, double[] y, int n, double koren)
        {
            double c, s = 0;
            for (int i = 0; i < n; i++)
            {
                c = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        c *= (koren - x[j]) / (x[i] - x[j]);
                    }
                }
                s += c * y[i];
            }
            return s;
        }

        private void button_gr_Click(object sender, EventArgs e)
        {
            Graph();
        }

        public void Graph()
        {
            GraphPane pane = zMain.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            double xmin = -100;
            double xmax = 100;
            for (double x = xmin; x <= xmax; x += 0.001)
            {
                list.Add(x, lp(mas_x, mas_y, n, x));
            }

            LineItem myCurve = pane.AddCurve("Пожилой Лагранж", list, Color.Purple, SymbolType.None);
            zMain.AxisChange();
            zMain.Invalidate();
        }

        private void Laba1_Load(object sender, EventArgs e)
        {
            pane = zMain.GraphPane;
            pane.Title.Text = "Приколы с графиком";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox_n.Text);
            mas_y = new double[n];
            mas_x = new double[n];
            comboBox_xy.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            label_xy.Visible = true;
            textBox_xy.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox_lpx.Visible = true;
            button4.Visible = true;
            textBox_lpy.Visible = true;
            textBox_n.Enabled = false;
            textBox_n.ReadOnly = true;
            button_gr.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox_xy.SelectedIndex == 0)
            {
                string[] rez;
                string stroka = textBox_xy.Text;
                rez = stroka.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    mas_x[i] = Convert.ToDouble(rez[i]);
                }
                MessageBox.Show("Точки X приняты");
            }

            if (comboBox_xy.SelectedIndex == 1)
            {
                string[] rez;
                string stroka = textBox_xy.Text;
                rez = stroka.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    mas_y[i] = Convert.ToDouble(rez[i]);
                }
                MessageBox.Show("Точки Y приняты");
            }
            textBox_xy.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double koren = Convert.ToDouble(textBox_lpx.Text);
            string rez = Convert.ToString(lp(mas_x, mas_y, n, koren));
            textBox_lpy.Text = rez;
        }
    }
}
