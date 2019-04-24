using System;

namespace ConsoleApp1
{
    public class Program
    {/// <summary>
    /// Иницилизатор класса
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rectungle myRectungle = new Rectungle
            {
                TopLeft = new Point(ptColor:PointColor.LightBlue) {X = 10, Y = 20},
                BottomRighr = new Point() {X=15,Y=25}
            };
            myRectungle.DisplayStatus();
            Console.ReadKey();
        }
    }

    public class Rectungle
    {
        private Point topLeft = new Point();
        private Point bottomRighr = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRighr
        {
            get { return bottomRighr; }
            set { bottomRighr = value; }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"TopLeft: {topLeft.X}:{topLeft.Y}:{topLeft.Color} BottomRighr{bottomRighr.X}:{bottomRighr.Y}:{bottomRighr.Color}");
        }

    }

    public enum PointColor
    {
        LightBlue = 1,
        BloodRed = 2,
        Gold = 3
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public Point(PointColor ptColor = PointColor.BloodRed)
        {
            Color = ptColor;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"X:{X} Y:{Y}");
            Console.WriteLine($"Point is {Color}");
        }


    }




}
