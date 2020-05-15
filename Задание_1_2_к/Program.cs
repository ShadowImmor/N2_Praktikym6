using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_2_к
{
    class Program
    {
        static int[,] Input()
        {
            int n, m;
            Console.WriteLine("Введите размерность массива:");
            bool prov = false;
            do
            {
                Console.Write("n = ");
                prov = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                    prov = false;
                if(!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("m = ");
                prov = int.TryParse(Console.ReadLine(), out m);
                if (m <= 0)
                    prov = false;
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    do
                    {
                        Console.Write("a[{0},{1}]= ", i, j);
                        prov = int.TryParse(Console.ReadLine(), out a[i, j]);
                        if (!prov)
                            Console.WriteLine("Некорректный ввод");
                    } while (!prov);
                }
            return a;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static void Change(int[,] a)
        {
            bool prov = false;
            int min;
            do
            {
                Console.Write("Введите минимальное значение:");
                prov = int.TryParse(Console.ReadLine(), out min);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i,j] < min)
                        a[i,j] = min;
        }
        static void Main(string[] args)
        {
            int[,] mas= Input();
            Console.WriteLine("Исходный массив:");
            Print(mas);
            Change(mas);
            Console.WriteLine("Измененный массив:");
            Print(mas);
            Console.ReadLine();
        }
    }
}
