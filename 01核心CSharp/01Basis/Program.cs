// using System;
using System;
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


            // 变量 C#编译器需要用某个初始值对变量进行初始化，才能在操作中使用改变量，
            // 多数编译器将未初始化标记为警告，C#编译器将其视为警告
            int i;
            i = 10;

            // 声明时赋值
            int a = 10;

            // 初始化多个变量，具有相同的数据类型
            int x = 10, y = 18;

            // int c=19,bool e = true; =>报错


            // 类型推断
            /*
             * 变量必须初始化
             * 初始化器不能为空
             * 初始化器须放在表达式中
             *
             */

            var name = "Jonty";
            var age = 20;
            var flag = true;
            Console.WriteLine($"name's type:{name.GetType()}");
            Console.WriteLine($"age's type:{age.GetType()}");
            Console.WriteLine($"flag's type:{flag.GetType()}");

            // 变量作用域
            /*
             * 1.只要类的局部变量在某个作用域内，其字段(成员变量)也在该作用域内
             * 2.局部变量存在于表示该变量的块语句或方法结束的右花括号之前的作用域内
             * 3.在for、while或类似语句中声明局部变量存在于该循环体中
             */

            // 数据类型
            // 整型=>int short long
            // 浮点型=>float double
            // 布尔型=>bool true/false 不能和整数值相互隐式转换
            // 字符型=>char
            // 预定义的引用类型=>object 所有类型的基类
            // string 字符串

            {
                // 字符串前＋@,忽略转义字符
                string filePath = @"C:\User\Window";

                // 字符串插值方式
                string user = "jonty";
                string newFilePath = $"my name is {user}";
            }

        }
    }
}
