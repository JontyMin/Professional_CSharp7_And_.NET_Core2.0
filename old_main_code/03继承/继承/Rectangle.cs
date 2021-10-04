using System;

namespace 继承
{
    public class Rectangle : Shape
    {
        /// <summary>
        /// 重写基类方法时，签名和返回类型必须一致
        /// 否则以后创建的新成员就不覆盖基类成员
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine($"Rectangle with {Position} and {Size}");
        }

        public override void Move(Position newPosition)
        {
            Console.WriteLine($"Rectangle");
            // 使用base关键字可以调用基类的任何方法
            base.Move(newPosition);
        }


        /// <summary>
        /// 派生类需要实现所有抽象成员
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public override void Resize(int width, int height)
        {
            Size.Width = width;
            Size.Height = height;
        }

        public Rectangle(int width, int height, int x, int y) : base(width, height, x, y)
        {
        }
    }
}