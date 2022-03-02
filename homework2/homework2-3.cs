using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] a = new bool[101];
            Console.WriteLine("2-100以内的素数（埃氏筛法）：");
            for (int i = 0; i <= 100; i++)
            {
                a[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(100); i++)
            {
                if (a[i] == true)
                {
                    for (int j = 2; i * j <= 100; j++)
                    {
                        a[i * j] = false;
                    }
                }
            }
            for (int i = 2; i <= 100; i++)
            {
                if (a[i] == true)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
