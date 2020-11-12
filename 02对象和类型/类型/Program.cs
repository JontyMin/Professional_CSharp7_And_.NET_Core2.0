using System;
using System.Globalization;

namespace 类型
{
    /*
     * 如果A是结构struct =>1
     * 结构是值类型，按值传递
     * ChangeA中的变量a得到堆栈中a1的一个副本
     * a1从创建到销毁始终没有改变
     *
     * 如果a是类 class =>2
     * 类是引用类型，按引用传递
     * ChangeA中的变量a得到的是a1的内存地址
     * 修改a的时候实际上也就是修改a1,属于同一个对象
     *
     */
    class A
    {
        public int X { get; set; }

    }

    struct AVaulrType
    {
        public int Data;
    }

    class B
    {
        public int? age { get; set; }
    }


    /// <summary>
    /// 枚举默认类型是int 可更改为其他整数类型
    /// byte、short、int、long
    /// </summary>
    enum Color:short
    {
        Red=1,
        Blue=2,
        Yellow=3
    }
    [Flags]
    enum DaysOfWeek
    {
        Monday=0x1,
        Tuesday=0x2,
        Wednesday=0x4,
        Thursday=0x8,
        Friday=0x10,
        Saturday=0x20,
        Sunday=0x40

    }


    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class StringExtension
    {
        public static int GetWordCount(this string s) => s.Split(',').Length;
    }

    class Program
    {
        static void Main(string[] args)
        {

            string str = "hello, I'm jonty ";
            int length = str.GetWordCount();// 编译器会改成调用静态方法
            Console.WriteLine(length);

            Color red;
            if (Enum.TryParse<Color>("Red",out red))
            {
                Console.WriteLine($"result = {red}");
            }

            // 返回所有枚举名数组
            foreach (var name in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine(name);
            }

            // 返回所有枚举值 需要指定具体的类型
            foreach (short value in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(value);
            }


            DayOfWeek mondayAndSunday = DayOfWeek.Monday | DayOfWeek.Sunday;
            Console.WriteLine(mondayAndSunday);

            Color c = Color.Red;

            // 使用强制类型转换
            Color c2 = (Color) 2;//Blue
            short c3 = (short) Color.Yellow;//3

            Console.WriteLine($"result:{c2}/{c3}");

            // 可空类型 必须是结构
            B b=new B();
            b.age = null;

            int x1 = 1;
            int? x2 = null;
            // int值可以分配给int
            int? x3 = x1;
            // 反之 不行
            //int x4 = x3;
            int x4 = (int) x3;

            // HasValue 判断是否有值 true/false
            int x5 = x3.HasValue ? x3.Value : -1;
            int x6 = x3 ?? -1;

            Console.WriteLine("Hello World!");
            // 任何变量在传递方法之前必须初始化
            A a1 = new A
            {
                X=1
            };

            // 使用ref就是按引用传递
            ChangeA(ref a1);
            Console.WriteLine($"a1.X:{a1.X}");


            string input1 = Console.ReadLine();
            int result = Int32.Parse(input1);
            Console.WriteLine($"Write input:{result}");

            string input2 = Console.ReadLine();
            int result2;

            // out参数允返回参数指定的值
            if (Int32.TryParse(input2,out result2))
            {
                Console.WriteLine($"Write input:{result2}");
            }
            else
            {
                Console.WriteLine($"Not a number");
            }
        }

        /// <summary>
        /// in 保证发送到方法中的参数数据不会被更改 值类型
        /// 主要用于值类型 也可用于引用类型=>可以更改变量内容，不能更改变量本身
        /// </summary>
        /// <param name="data"></param>
        static void CantChange(in AVaulrType data)
        {
            // data.Data = 1; error
            Console.WriteLine(data.Data);
        }

        /// <summary>
        /// ref 通过引用传递 A struct=>2
        /// </summary>
        /// <param name="a"></param>
        public static void ChangeA(ref A a)
        {
            a.X = 2;

            // 不使用ref=>并没有用到新对象，回收
            // 使用ref 传递对引用的引用 =>指向指针的指针 分配一个新对象
            a=new A {X=3};
        }
    }
}
