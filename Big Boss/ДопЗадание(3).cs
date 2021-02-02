using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Big_Boss
{
    public partial class ДопЗадание3 : Form
    {
        public ДопЗадание3()
        {
            InitializeComponent();
        }
        double pi = 3.14;

        double Func1(double x)//f(x)
        {

            return x * x - (Math.Cos(pi * x));
        }

        double PFunc(double x)//f"(x)
        {
            return 2 * x + (1 / x);//2 производная от x*x-(cos(pi*x))
        }

        double Func2(double x)
        {

            return Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 3 * x + 11;
        }

        public void Graph(double a, double b)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            for (double x = a; x <= b; x += 0.01)
            {
                list1.Add(x, Func1(x));
                list2.Add(x, Func2(x));
            }
            LineItem myCurve1 = pane.AddCurve("Функция1", list1, Color.Purple, SymbolType.None);//настройки графика
            LineItem myCurve2 = pane.AddCurve("Функция2", list2, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            double a = (TextBoxA.Text != "") ? Convert.ToDouble(TextBoxA.Text) : 0;
            double b = (TextBoxB.Text != "") ? Convert.ToDouble(TextBoxB.Text) : 0;
            double c;
            double Eps = (TextBoxEps.Text != "") ? Convert.ToDouble(TextBoxEps.Text) : 0;

            Graph(a, b);

            if (Func1(a) * Func2(a) > 0)
            {
                c = a;
            }
            else
            {
                c = b;
            }
            do
            {
                c = c - Func1(c) / PFunc(c);
                n++;
            }
            while (Math.Abs(Func1(c)) >= Eps);

            Answer.Text+="Ответ = "+ c + "\n";
            Answer.Text += "Кол-во итераций = " + n + "\n";
        }
    }
}
