using System;

namespace _02程序流控制
{
    class Program
    {
        static void Main(string[] args)
        {
           // 控制程序流语句
           // 1.条件语句:根据条件是否满足或根据表达式的值来控制代码的执行分支
           // if语句:测试特定条件是否满足
           // switch:比较表达式和多个不同的值

           Console.WriteLine("Type is String");
           string input = Console.ReadLine();
           if (input=="")
           {
               Console.WriteLine("You typed in an empty string");
           }else if (input.Length<5)
           {
               Console.WriteLine("The string had less than 5 characters");
           }
           else
           {
               Console.WriteLine($"The string is {input}");
           }

           // else if 个数不受限制


           // switch 从一组互斥的可执行分支中选择一个执行分支
           int a = new Random().Next(3);
           switch (a)
           {
                case 1:
                    Console.WriteLine("This is 1");
                    break;
                case 2:
                    Console.WriteLine("This is 2");
                    break;
                default:
                    Console.WriteLine("This is fuck");
                    break;
           }

           // 处理多条case
           switch (a)
           {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("less than 3");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("more than 3");
                    break;
                default:
                    Console.WriteLine("This is also fuck");
                    break;
           }
        }
    }
}
