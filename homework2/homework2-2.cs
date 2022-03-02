using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数数组，用空格隔开：");
            string Array = Console.ReadLine();
            string[] Spl = Array.Split(' ');
            int len = Spl.Length;
            int[] array= new int[len];
            for(int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Spl[i]);
            }
            int max = array[0];
            int min = array[0];
            int sum = array[0];
            for(int i = 1; i < len; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                sum = sum + array[i];
            }
            for(int i = 1; i < len; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            int ave = sum / len;
            Console.WriteLine("数组的最大值，最小值，平均值，数组元素和依次为：");
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(ave);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
