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

           // for循环 预测试循环 在执行循环之前判断循环条件 false则不执行循环体
           for (int i = 0; i < 10; i++)
           {
               Console.WriteLine($"Hi!{i}");
           }            

           // 嵌套
           for (int i = 0; i < 100; i+=10)
           {
               // i=0 j=0 j<10 j++
               for (int j = i; j < i+10; j++)
               {
                   Console.Write($"{j}");
               }

               Console.WriteLine();
           }

           // while 不确定次数循环
           bool condition = 1 > 0 ? true : false;
           while (!condition)
           {
               // do something
           }

           // do-while 和while一致，循环体会先执行一次再判断条件
           do
           {
               // do something
           } while (!condition);


           // foreach循环 迭代集合中的项
           int[] arr = {1, 2, 3, 4, 5};
           foreach (var i in arr)
           {
               Console.WriteLine(i);
           }

           // 注意:使用foreach循环不能改变集合中的项 循环改变集合中的各项使用for循环

           // 跳转语句
           // 1.goto语句 跳转到标签指定的一行
           // 不能跳转到循环语句中，不能跳转到类外
           goto go1;
           Console.WriteLine("that");

           go1:
           Console.WriteLine("this");

           // break switch:退出case for:退出循环

           // continue 退出循环的当前迭代 执行下一次迭代 不退出循环

           // return 退出方法，返回方法类型 void方法没有return
        }
    }
}
