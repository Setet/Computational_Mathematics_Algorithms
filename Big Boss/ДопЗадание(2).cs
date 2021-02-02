using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Big_Boss
{
    public partial class Laba4 : Form
    {
        public Laba4()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string file = Reader.Text;

            int N = MatrixLines(file);

            double[,] A = new double[N, N];


            MatrixReader(A, file);

            //обратная матрица СмОбратная
            double[,] AObrat = new double[N, N];
            double[,] ACopy = new double[N, N];

            Answer.Text += "Начальная матрица :" + "\n";

            //задаем обратную матрицу как единичную           
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        AObrat[i, j] = 1; 
                    }
                    else 
                    {
                        AObrat[i, j] = 0; 
                    }
                    ACopy[i, j] = A[i, j];    //создаем копию матрицы См
                    Answer.Text += ACopy[i, j]+" ";
                }
                Answer.Text += "\n";
            }

            //прямой ход
            for (int k = 0; k < N; ++k)
            {
                double div = ACopy[k, k];
                for (int m = 0; m < N; ++m)
                {// делим строку на выбранный элемент === 1  ф  ф
                    ACopy[k, m] /= div;
                    AObrat[k, m] /= div;
                }
                for (int i = k + 1; i < N; ++i) //идем по столбц ниже полученой единицы
                {
                    double multi = ACopy[i, k]; //элемент, который хотим занулить
                    for (int j = 0; j < N; ++j)// элемент по счету в строке i
                    {
                        ACopy[i, j] -= multi * ACopy[k, j];
                        AObrat[i, j] -= multi * AObrat[k, j];
                    }
                }

            }

            Answer.Text += "| ------------------------------|" + "\n";
            Answer.Text += "После прямого хода" + "\n";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Answer.Text += ACopy[i, j] + " ";
                }
                Answer.Text += "\n";
            }

            //обратный ход            
            for (int kk = N - 1; kk > 0; kk--)
            {

                for (int i = kk - 1; i + 1 > 0; i--)
                {
                    double multi2 = ACopy[i, kk];
                    for (int j = 0; j < N; j++)
                    {
                        ACopy[i, j] -= multi2 * ACopy[kk, j];
                        AObrat[i, j] -= multi2 * AObrat[kk, j];
                    }
                }
            }

            Answer.Text += "| ------------------------------|" + "\n";
            Answer.Text += "Проверка матрицы Copy" + "\n";

            double[,] Ee = new double[N, N];
            int flagA = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Answer.Text += AObrat[i, j] + " ";
                    if (i == j)
                    {
                        Ee[i, j] = 1; 
                    }
                    else
                    {
                        Ee[i, j] = 0; 
                    }
                    if (Ee[i, j] != ACopy[i, j]) 
                    {
                        Answer.Text += "i=" + i + "\n";
                        Answer.Text += "j=" + j + "\n";
                    }
                    else
                    {
                        flagA = 1;
                    }
                }
                Answer.Text += "\n";
            }
            if (flagA == 1)
            {
                Answer.Text += "Матрица стала единичной" + "\n"; 
            }

            //проверка СмОбратной
            //CmObrat*Cm
            double[,] ProverkaA = new double[N, N];
            for (int i = 0; i < N; i++)//строки
            {
                for (int j = 0; j < N; j++)//столбцы
                {
                    for (int k = 0; k < N; k++)
                    {
                        ProverkaA[i, j] += AObrat[i, k] * A[k, j];
                    }
                }
            }
        }

        private void Answer_TextChanged(object sender, EventArgs e)//Авто-скролл
        {
            Answer.SelectionStart = Answer.Text.Length;
            Answer.ScrollToCaret();
        }

        private void txt_Click(object sender, EventArgs e)//Мне лень каждый раз писать .txt
        {
            Reader.Text += ".txt";
        }
    }
}   