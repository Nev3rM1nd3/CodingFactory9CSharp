using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new(15);
            Point p2 = new Point2D(15, 18);
            Point p3 = new Point3D(15, 18, 20);
        }

        public static void DoMove5(Point point)
        {
            point.Move5();
        }
        public static void DoPrint(Point p)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
