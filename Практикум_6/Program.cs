using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_1_к
{
    class Program
    {
        static int[] Input()
        {
            int n;
            bool prov = false;
            do
            {
                Console.Write("Введите размерность массива:");
                prov = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                    prov = false;
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                do
                {
                    Console.Write("a[{0}]= ", i);
                    prov = int.TryParse(Console.ReadLine(), out a[i]);
                    if (!prov)
                        Console.WriteLine("Некорректный ввод");
                } while (!prov);
            }
            return a;
        }
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void Change(int[] a)
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
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < min)
                    a[i] = min;
        }
        static void Main(string[] args)
        {
            int[] mas = Input();
            Console.WriteLine("Исходный массив:");
            Print(mas);
            Change(mas);
            Console.WriteLine("Измененный массив:");
            Print(mas);
            Console.ReadLine();
        }
    }
}