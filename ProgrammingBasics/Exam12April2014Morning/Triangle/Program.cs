namespace Triangle
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double aX = double.Parse(Console.ReadLine());
            double aY = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());

            double ab = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2));
            double bc = Math.Sqrt(Math.Pow(bX - cX, 2) + Math.Pow(bY - cY, 2));
            double ac = Math.Sqrt(Math.Pow(aX - cX, 2) + Math.Pow(aY - cY, 2));

            bool pointsFormTriangle = CheckIfTriangleCanBeFormed(ab, bc, ac);
            if (!pointsFormTriangle)
            {
                Console.WriteLine($"No{Environment.NewLine}{ab:f2}");
                return;
            }

            double halfPerimeter = (ab + bc + ac) / 2;
            double triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - ab) * (halfPerimeter - bc) * (halfPerimeter - ac));
            Console.WriteLine($"Yes{Environment.NewLine}{triangleArea:f2}");
        }

        private static bool CheckIfTriangleCanBeFormed(double ab, double bc, double ac)
        {
            return (ab + bc > ac && bc + ac > ab && ac + ab > bc);
        }
    }
}
