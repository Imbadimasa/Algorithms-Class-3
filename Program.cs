using System;

namespace Algorithms_Class_3
{
    class Program
    {

        public class Point
        {
            private double x, y;
            public Point (double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X { get { return x; } private set { x = value; } }
            public double Y { get { return y; } private set { y = value; } }

        }

        public struct GetDistance
        {
                public static double Distance (double x1, double y1, double x2, double y2)
            {
                double dis = Math.Sqrt((x1 - x2)*(x1-x2) + ((y1 - y2) * (y1 - y2)));
                return dis;
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(1, 4);
            Point B = new Point(5, 10);

            double result = GetDistance.Distance(A.X, A.Y, B.X, B.Y);
            Console.WriteLine(result);
        }
    }
}
