using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Big_Boss
{
    public partial class Задание2 : Form
    {
        GraphPane pane;
        public Задание2()
        {
            InitializeComponent();
        }

        private void Laba2_Load(object sender, EventArgs e)
        {
            pane = zMain.GraphPane;
            pane.Title.Text = "Приколы с графиком";
        }

        double func(double x)
        {
            return Math.Pow(x, 2) + Math.Sin(x);
        }

        double Central_Squers(double a, double b, double n)
        {
            double sum = 0;//результат вычисления интеграла.
            double h = (b - a) / n;//вычисляем шаг - h

            for (int i = 0; i < n; i++)//в цикле применяем формулу центральных прямоугольников
            {
                sum += func(a + h * (i + 0.5)) * h;//складываем все суммы площадей прямоугольников,func(...) - результат значения, подставленного в функцию a - высота,h - ширина
            }                                      
            return sum;                           
        }

        double Simpson_Parable(double a, double b, double n)
        {
            double h = (b - a) / n;//вычисляем шаг - h
            double sum = 0;//результат вычисления интеграла.
            double x0 = a;//правая граница подотрезка отрезка [a, b]
            double x1 = a + h;//левая граница подотрезка отрезка [a, b]

            for (int i = 0; i < n; i++)//в цикле применяем формулу Симпсона
            {
                sum += func(x0) + 4 * func(x0 + h / 2) + func(x1);//для каждого подотрезка, и складываем все полученные значения в общую сумму.
                x0 += h;//сдвигаем левую и правую границу
                x1 += h;
            }

            return (h / 6) * sum;//возвращаем сумму умноженную на (h/6)(по формуле), т.к. (h/6) общий множитель который можно вынести за скобки.
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            buttonCreate.Visible = false;
            textBoxA.Enabled = false;
            textBoxA.ReadOnly = true;
            textBoxB.Enabled = false;
            textBoxB.ReadOnly = true;
            textBoxEps.Enabled = false;
            textBoxEps.ReadOnly = true;
            label4.Visible = true;
            comboBox.Visible = true;
            buttonNice.Visible = true;

            zMain.GraphPane.CurveList.Clear();
            PointPairList list = new PointPairList();
            double xmin = Convert.ToDouble(textBoxA.Text);
            double xmax = Convert.ToDouble(textBoxB.Text);

            for (double x = xmin; x <= xmax; x += 0.1)
            {
                list.Add(x, func(x));
            }
            //ось X будет пересекаться с осью Y на уровне Y = 0,ось Y будет пересекаться с осью X на уровне X = 0
            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;

            //уберём отображение первых и последних меток по осям
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;

            //уберём отображение меток в точке пересечения с другой осью
            pane.XAxis.Scale.IsSkipCrossLabel = true;

            //уберём отображение первых и последних меток по осям
            pane.YAxis.Scale.IsSkipFirstLabel = true;

            //уберём отображение меток в точке пересечения с другой осью
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;

            //уберём заголовки осей
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            LineItem myCurve = pane.AddCurve("Функция", list, Color.Black, SymbolType.None);//сама функция

            //заливку для кривой
            myCurve.Line.Fill = new ZedGraph.Fill(Color.Purple);//хз за чем это,но я где-то читал что нужно так делать

            zMain.AxisChange();
            zMain.Invalidate();
        }

        private void buttonNice_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)//для прямоугольников
            {
                double n = 1;
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double E = Convert.ToDouble(textBoxEps.Text);

                while (Math.Abs(Central_Squers(a, b, 2 * n) - Central_Squers(a, b, n)) / 3 > E) n *= 2;
                n *= 2;//Точность для формул прямоугольников равна 1/3 ( I2n - In)
                double Answer = Central_Squers(a, b, n);

                label5.Text = "";
                label5.Text += "Значение интеграла = " + Answer.ToString() + "\n";
                label5.Text += "Кол-во отрезков - " + n + "\n";
                label5.Text += "Длина шага - " + Math.Abs(a - b) / n;
            }
            if (comboBox.SelectedIndex == 1)//для Симпсона
            {
                double n = 1;
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double E = Convert.ToDouble(textBoxEps.Text);

                while (Math.Abs(Simpson_Parable(a, b, 2 * n) - Simpson_Parable(a, b, n)) / 15 > E) n *= 2;
                n *= 2;//Точность для формулы Симпсона (парабол) равна 1/15 (I2n - In)
                double Answer = Simpson_Parable(a, b, n);

                label5.Text = "";
                label5.Text += "Значение интеграла = " + Answer.ToString() + "\n";
                label5.Text += "Кол-во отрезков - " + n + "\n";
                label5.Text += "Длина шага - " + Math.Abs(a - b) / n;
            }
        }
    }
}
