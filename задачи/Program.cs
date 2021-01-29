using System;

namespace задачи
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            var rectagle = new Rectagle(a, b);
            Console.WriteLine("area = "+rectagle.AreaCalculator());
            Console.WriteLine("perimetr =" +rectagle.PerimeterCalculator());
        }
    }
    class Rectagle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectagle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        } 
    }
}


