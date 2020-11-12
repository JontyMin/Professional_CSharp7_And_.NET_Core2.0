using System;

namespace Struct
{
    class Program
    {

        public readonly struct Dimensions
        {
            public Dimensions(double length,double width)
            {
                Length = length;
                Width = width;
            }

            public double Length { get;  }
            public double Width { get; }

            public double Diagonal => Math.Sqrt(Length * Length + Width * Width);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 结构主要用于小的数据结构

            // new运算符不分配内存空间 只调用相应的构造函数 初始化字段
            Dimensions dimensions=new Dimensions();
            //dimensions.Width = 10;
            // dimensions.Length = 20;

            Dimensions point = default;
            double d = point.Width;

        }
    }
}
