namespace 继承
{
    public class Ellipse : Shape
    {
        /// <summary>
        /// new关键字不应故意使用隐藏方法
        /// 主要目的是处理版本冲突
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public new void MoveBy(int x, int y)
        {
            Position.X += x;
            Position.Y += y;
        }

        public override void Resize(int width, int height)
        {
            Size.Width = width;
            Size.Height = height;
        }

        public Ellipse(int width, int height, int x, int y) : base(width: 0, height: 0, x: 0, y: 0)
        {
        }
    }
}