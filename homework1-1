using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Program
    {
        private static double num1 = 0, num2 = 0, res = 0;
        private static string str = null;

        static void calculate(string choice)
        {
            switch(choice)
            {
                case "+":res = num1 + num2;break;
                case "-":res = num1 - num2;break;
                case "*":res = num1 * num2;break;
                case "/":if (num2 == 0) { Console.WriteLine("除数不能为零"); }
                    else { res = num1 / num2; }
                    break;       
            }    
        }

        static void Main(string[] args)
        {
            Console.WriteLine("加减乘除四则运算计算器");
            Console.WriteLine("请输入第一个参数：");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个参数：");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            str = Console.ReadLine();
            if (str == "0")
            {
                Console.WriteLine("请输入正确的运算符");
            }
            else
            {
                calculate(str);
            }
            Console.WriteLine("得出结果：");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
