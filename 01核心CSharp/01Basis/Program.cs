// using System;
using static System.Console;
namespace _01Basis
{
    class Program
    {
        /// <summary>
        /// 每个C#可执行程序都包含一个入口点 Main方法(M大写)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            WriteLine($"System空间包含了常用的.NET类型");

            // 注意：C#区分大小写


            // 变量
            int i;
            i = 10;

            // 声明时赋值
            int a = 10;

            // 初始化多个变量，具有相同的数据类型
            int x = 10, y = 18;

            // int c=19,bool e = true; =>报错
        }
    }
}
