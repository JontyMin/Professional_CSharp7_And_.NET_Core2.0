using System;

namespace 继承
{
    class Program
    {
        /*
         * 继承：
         * 单重继承：一个类可以派生自一个基类=>C#
         * 多重继承：一个类可以派生自多个基类(多重继承会带来复杂性)，C#只允许接口的多重继承
         * 多层继承：允许继承有更大的层次结构。A=>B=>C
         * 接口继承：定义接口的继承，允许多重继承
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var r = new Rectangle(1,2,3,5) {Position = {X = 100, Y = 40}, Size = {Width = 12, Height = 20}};
            r.Draw();
            DrawShape(r);

            r.Move(new Position() {X = 120, Y = 20});

            Shape s1 = new Ellipse(1,2,4,5);
            DrawShape(s1);
        }
        public static void DrawShape(Shape shape) => shape.Draw();

    }
}
