using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_к
{
    class Program
    {
        static float[] Input()
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
            float[] a = new float[n];
            for (int i = 0; i < n; ++i)
            {
                do
                {
                    Console.Write("a[{0}]= ", i);
                    prov = float.TryParse(Console.ReadLine(), out a[i]);
                    if (!prov)
                        Console.WriteLine("Некорректный ввод");
                } while (!prov);
            }
            return a;
        }

        static void Print(float[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void PrintIndexMin(float[] a)
        {
            float min = a.Min();
            int[] index = a.Select((n, i) => n == min ? i : -1).Where(n => n != -1).ToArray();
            string strindex = string.Join(" ", index);
            Console.Write("Номера всех минимальных элементов:" + strindex);
        }
        static void Main(string[] args)
        {
            float[] mas = Input();
            Console.WriteLine("Массив:");
            Print(mas);
            PrintIndexMin(mas);
            Console.ReadLine();
        }
    }
}
