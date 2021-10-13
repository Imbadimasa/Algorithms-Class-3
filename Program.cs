using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms_Class_3
{
    class Program
    {
        //Class with Double
        #region 
        public class PointC
        {
            private double x, y;
            public PointC (double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X { get { return x; } private set { x = value; } }
            public double Y { get { return y; } private set { y = value; } }

        }

        public class GetDistanceC
        {
            public static double Distance(PointC A, PointC B)
            {
                double dis = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
                return dis;
            }
        }

        #endregion //


        //Struct with Double
        #region
        public struct PointS
        {
            private double x, y;

            //
            public PointS(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X { get { return x; } private set { x = value; } }
            public double Y { get { return y; } private set { y = value; } }

        }

        public struct GetDistanceS
        {
            public static double Distance(PointS A, PointS B)
            {
                double dis = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
                return dis;
            }
        }
        #endregion


        //Struct with Float
        #region
        public struct PointSFloat
        {
            private float x, y;

            //
            public PointSFloat(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public float X { get { return x; } private set { x = value; } }
            public float Y { get { return y; } private set { y = value; } }

        }

        public struct GetDistanceSFloat
        {
            public static float Distance(PointSFloat A, PointSFloat B)
            {
                float dis = (float)(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
                return dis;
            }
        }

        #endregion


        static void Main(string[] args)
        {
            Stopwatch watchClass = new Stopwatch(); //Class with double value
            watchClass.Start();
            PointC AC = new PointC(1, 4);
            PointC BC = new PointC(5, 10);

            double resultC = GetDistanceC.Distance(AC, BC);
            watchClass.Stop();
            Console.WriteLine(resultC);
            Console.WriteLine(watchClass.Elapsed);

            Stopwatch watchStruct = new Stopwatch(); //Struct with double value
            watchStruct.Start();
            PointS AS = new PointS(1, 4);
            PointS BS = new PointS(5, 10);

            double resultS = GetDistanceS.Distance(AS, BS);
            watchStruct.Stop();
            Console.WriteLine(resultS);
            Console.WriteLine(watchStruct.Elapsed);

            Stopwatch watchStructFloat = new Stopwatch(); //Struct with float value
            watchStructFloat.Start();
            PointSFloat ASFloat = new PointSFloat(1, 4);
            PointSFloat BSFloat = new PointSFloat(5, 10);

            float resultSFloat = GetDistanceSFloat.Distance(ASFloat, BSFloat);
            watchStructFloat.Stop();
            Console.WriteLine(resultSFloat);
            Console.WriteLine(watchStructFloat.Elapsed);

            Console.WriteLine("Conclusion: Struct with Double values is the fastest.");

        }
    }
}
