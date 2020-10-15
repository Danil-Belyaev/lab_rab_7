using System;

namespace Перегрузки
{

    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int M;
            Random rand = new Random();

            Console.Write("Введите высоту матрицы  0<=N<=25 > ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину матрицы  0<=M<=25 > ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Инициализация и вывод исходной матрицы
            Console.WriteLine("   Исходная матрица: ");
            int[,] mas = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(rand.Next(100));
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Нахождение минимального элемента матрицы
            Console.WriteLine("Минимальный элемент матрицы : ");
            int minimal = mas[1, 1];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < minimal)
                    { minimal = mas[i, j]; }
                }
            }
            Console.WriteLine(minimal);

            // Нахождение максимального элемента матрицы
            Console.WriteLine("Максимальный элемент матрицы : ");
            int maximal = mas[1, 1];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > maximal)
                    { maximal = mas[i, j]; }
                }
            }
            Console.WriteLine(maximal);
        }
    }
}
