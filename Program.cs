using System;
using System.IO;

namespace Перегрузки
{

    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            int N;
            int M;
#endif
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
#endif

#if DEBUG
            Console.Write("Введите высоту матрицы  0<=N<=25 > ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину матрицы  0<=M<=25 > ");
            M = Convert.ToInt32(Console.ReadLine());
#endif
            Console.WriteLine();
            Matrix a = new Matrix(N, M);

            a.Print();


            Console.WriteLine("Минимальный элемент матрицы : ");
            Console.WriteLine(a.Min());


            Console.WriteLine("Максимальный элемент матрицы : ");
            Console.WriteLine(a.Max());
#if DEBUG
            Console.ReadKey();
#endif

# if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
# endif
        }
    }
}
