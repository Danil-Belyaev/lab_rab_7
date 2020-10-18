using System;
using System.Collections.Generic;
using System.Text;

namespace Перегрузки
{
    class Matrix
    {
        int[,] mas;
        public Matrix(int N, int M)
        {
            this.M = M;
            this.N = N;
            mas = new int[N, M];

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(rand.Next(100));
                }
            }
        }

        public Matrix() : this(1, 1)
        {

        }

        public Matrix(Matrix a)
        {
            mas = new int[a.M, a.N];
            // скопировать все из a в mas
        }

        public int N;
        public int M;


        public void Print(string p)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(mas[i, j] + p);
                }
                Console.WriteLine("");
            }
        }

        public void Print()
        {
            Print("\t");
        }

        public int Max()
        {
            int maximal = mas[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > maximal)
                    { maximal = mas[i, j]; }
                }
            }
            return maximal;
        }

        public int Min()
        {
            int minimal = mas[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < minimal)
                    { minimal = mas[i, j]; }
                }
            }
            return minimal;
        }

        public int Min(int i)
        {
            if (i < N)
            {
                int minimal = mas[0, 0];
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < minimal)
                    { minimal = mas[i, j]; }
                }

                return minimal;
            }
            else return 0;

        }
    }
}
