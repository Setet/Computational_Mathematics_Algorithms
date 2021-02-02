using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Big_Boss
{
    public partial class Задание7 : Form
    {
        public Задание7()
        {
            InitializeComponent();
        }

        double Func(double x)
        {
            return Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 3 * x + 11;//функция
        }

        public void Graph(double a, double b)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();

            PointPairList list = new PointPairList();

            for (double x = a; x <= b; x += 0.01)
            {
                list.Add(x, Func(x));
            }
            LineItem myCurve = pane.AddCurve("Функция", list, Color.Purple, SymbolType.None);//настройки графика

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a = (A.Text != "") ? Convert.ToDouble(A.Text) : 0;//считываем значения a,b и Eps
            double b = (B.Text != "") ? Convert.ToDouble(B.Text) : 0;
            double Eps = (this.Eps.Text != "") ? Convert.ToDouble(this.Eps.Text) : 0;

            Graph(a, b);

            int n = 0;
            double c = (a + b) / 2;

            while (Math.Abs(a - b) > Eps)
            {
                n++;

                if (Func(a) * Func(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                c = (a + b) / 2;
            }
            Answer.Text += "Количество итераций = " + n+"\n";
            Answer.Text += "x = " + c+"\n";
        }
    }
}
