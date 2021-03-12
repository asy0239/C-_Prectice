using System;

namespace Struct
{
    class Program
    {
        struct MyPoint
        {
            public int X;
            public int Y;
            
            public MyPoint(int x , int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return string.Format("{0},{1}", X, Y);
            }
        }
        static void Main(string[] args)
        {
            MyPoint myPoint = new MyPoint(10, 20);
            Console.WriteLine(myPoint.ToString());
        }
    }
}
