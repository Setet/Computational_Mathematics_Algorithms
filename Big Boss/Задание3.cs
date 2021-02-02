using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
//
//Мод.Метод Гауса с выбором гравного элемента
//
namespace Big_Boss
{
    public partial class Задание3 : Form
    {
        public Задание3()
        {
            InitializeComponent();
        }

        int MatrixColumns(string file)// n - кол-во столбцов
        {
            StreamReader srN = new StreamReader(file);
            string line = srN.ReadLine();
            srN.Close();
            string[] entries = line.Split(' ');

            return entries.Length;
        }

        int MatrixLines(string file)// кол-во строк
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            return lines.Capacity;
        }

        void MatrixReader(double[,] Matrix, string file)
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            int n = Matrix.GetLength(1);
            int i = 0;
            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    Matrix[i, j] = Double.Parse(entries[j]);
                }
                i++;
            }
        }//Чтение матрицы из файла

        void PrintMatrix(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    richTextBox1.Text += Matrix[i, j] + " ";
                }
                richTextBox1.Text += "\t" + Matrix[i, n] + "\n";
            }
            richTextBox1.Text += "|------------------------------|\n";
        }//Вывод матрицы в текстбокс

        int MaxElementColumn(double[,] Matrix, int k)
        {
            double MaxElement = Matrix[k, k];
            int MaxElementColumn = k;
            int n = Matrix.GetLength(0);

            for (int i = k; i < n; i++)
            {
                if (Math.Abs(MaxElement) < Math.Abs(Matrix[i, k]))
                {
                    MaxElement = Matrix[i, k];
                    MaxElementColumn = i;
                }
            }
            return MaxElementColumn;
        }//Поиск в k - ом столбце строки с максимальным элементом

        void Change(double[,] Matrix, int Line1, int Line2)
        {
            int k = Matrix.GetLength(1);
            double[] Temporary = new double[k];

            for (int j = 0; j < k; j++)
            {
                Temporary[j] = Matrix[Line1, j];
                Matrix[Line1, j] = Matrix[Line2, j];
                Matrix[Line2, j] = Temporary[j];
            }
        }//Меняем местами 2 строки из матрицы

        public void DoTriangleDown(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            double coefficient = 0;

            for (int i = 0; i < n; i++)
            {
                Change(Matrix, MaxElementColumn(Matrix, i), i);
                coefficient = Matrix[i, i];
                for (int j = i; j < k; j++)
                {
                    Matrix[i, j] /= coefficient;
                }
                LineWorkDown(Matrix, i);
            }
        }//Приводим к треугольному виду, прямой ход

        void LineWorkDown(double[,] Matrix, int Line)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            for (int i = Line + 1; i < n; i++)
            {
                double coeff = Matrix[i, Line];
                for (int j = Line; j < k; j++)
                {
                    Matrix[i, j] -= Matrix[Line, j] * coeff;
                }
            }
        }//Работа со строкой при прямом ходе

        public void DoTriangleUp(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    double coeff = Matrix[j, i];
                    Matrix[j, i] = 0;
                    Matrix[j, k - 1] -= Matrix[i, k - 1] * coeff;
                }
            }
        }//Приводим к треугольному виду, обратный ход

        double[] VectorNeviazok(double[,] Matrix, double[] Vector)//Вектор невязок
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);
            double[] Result = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    Result[i] += Matrix[i, j] * Vector[j];//Перемножаем вектор-ответ с изначальной матрицей
                }
            }
            for (int i = 0; i < n; i++)
            {
                Result[i] = Matrix[i, k - 1] - Result[i];//Находим вектор невязки
            }
            return Result;
        }

        private void Calculate_Click(object sender, EventArgs e)//Босс этой качалки
        {
            richTextBox1.Text = "";
            string file = textBox1.Text;
            int i = MatrixLines(file);// i - строки
            int j = MatrixColumns(file);// j - столбцы

            double[,] A = new double[i, j];
            double[,] Matrix = new double[i, j];

            MatrixReader(A, file);
            MatrixReader(Matrix, file);

            richTextBox1.Text += "Начальная матрица :\n";
            PrintMatrix(Matrix);
            DoTriangleDown(Matrix);
            DoTriangleUp(Matrix);

            richTextBox1.Text += "Преобразованная матрица :\n";
            PrintMatrix(Matrix);

            richTextBox1.Text += "Решение:\n";
            double[] Result = new double[i];//Выводим результат
            for (int x = 0; x < i; x++)
            {
                Result[x] = Matrix[x, i];
                richTextBox1.Text += "x" + x + " = " + Result[x] + "\n";
            }

            richTextBox1.Text += "|------------------------------|\n";
            richTextBox1.Text += "Вектор невязок\n";
            Result = VectorNeviazok(A, Result);//Выводим вектор невязки
            for (int x = 0; x < i; x++)
            {
                richTextBox1.Text += Result[x] + "\n";
            }

            double Norma = 0;
            for (int x = 0; x < i; x++)
            {
                Norma += Math.Abs(Result[x]);//Находим и выводим норму
            }
            richTextBox1.Text += "| ------------------------------|\n";
            richTextBox1.Text += "||X1|| = " + Norma;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)//Авто-скролл
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)//Мне лень каждый раз писать .txt
        {
            textBox1.Text += ".txt";
        }
    }
}