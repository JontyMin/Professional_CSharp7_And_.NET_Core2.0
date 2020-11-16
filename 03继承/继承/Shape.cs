using System;

namespace 继承
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X:{X},Y:{Y}";
    }

    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString() => $"Width:{Width},Height:{Height}";
    }
    public abstract class Shape
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        protected Shape(int width,int height,int x,int y)
        {
            Size=new Size(){Width = width,Height = height};
            Position = new Position() {X = x, Y = y};
        }

        public Position Position { get;  }

        public Size Size { get; }


        /// <summary>
        /// 把一个基类方法声明为虚方法
        /// 其任何派生类都可以重写此方法
        /// C#中虚函数需要显示指定 virtual
        /// </summary>
        public virtual void Draw() => Console.WriteLine($"Shape with {Position} and {Size}");


        public virtual void Move(Position newPosition)
        {
            Position.X = newPosition.X;
            Position.Y = newPosition.Y;
            Console.WriteLine($"Move to {Position}");
        }

        public abstract void Resize(int width, int height);
    }
}