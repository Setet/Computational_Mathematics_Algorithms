using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Big_Boss
{
    public partial class Задание6 : Form
    {
        public Задание6()
        {
            InitializeComponent();
        }

        double Func(double x, double y)
        {
            return 6 * Math.Pow(x, 2) + 5 * x * y;
        }

        public void Graph(double x0, double y0, double step1,double step2,double step3,double step4)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            PointPairList listFunc = new PointPairList();

            for (double x = 0; x <= 1; x += 0.001)
            {
                listFunc.Add(x, Func(x, x));
            }
            LineItem CurveFunc = pane.AddCurve("Сама функция", listFunc, Color.Blue, SymbolType.None);

            PointPairList listEuler1 = new PointPairList();
            PointPairList listEuler2 = new PointPairList();
            PointPairList listEuler3 = new PointPairList();
            PointPairList listEuler4 = new PointPairList();

            while (x0 <= 1)
            {
                listEuler1.Add(x0, Func(x0, y0));
                y0 += step1 * Func(x0, y0);
                x0 += step1;

                listEuler2.Add(x0, Func(x0, y0));
                y0 += step2 * Func(x0, y0);
                x0 += step2;

                listEuler3.Add(x0, Func(x0, y0));
                y0 += step3 * Func(x0, y0);
                x0 += step3;

                listEuler4.Add(x0, Func(x0, y0));
                y0 += step4 * Func(x0, y0);
                x0 += step4;
            }

            LineItem CurveEuler1 = pane.AddCurve("Метод Эйлера Шаг=0.1", listEuler1, Color.Red, SymbolType.None);
            LineItem CurveEuler2 = pane.AddCurve("Метод Эйлера Шаг=0.01", listEuler2, Color.Green, SymbolType.None);
            LineItem CurveEuler3 = pane.AddCurve("Метод Эйлера Шаг=0.001", listEuler3, Color.Purple, SymbolType.None);
            LineItem CurveEuler4 = pane.AddCurve("Метод Эйлера Шаг=0.0001", listEuler4, Color.Black, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double x0 = (TextBoxX.Text != "") ? Convert.ToDouble(TextBoxX.Text) : 0;
            double y0 = (TextBoxY.Text != "") ? Convert.ToDouble(TextBoxY.Text) : 0;
            double step1 = 0.1, step2 = 0.01, step3 = 0.001, step4 = 0.0001;
            Graph(x0, y0, step1,step2,step3,step4);
        }
    }
}
