using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("给定一个数组，当且仅当它是托普利茨矩阵时返回true：");
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            bool t=true;
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (array[i,j] != array[i - 1,j - 1])
                    {
                        t=false;
                    }
                }
            }
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
