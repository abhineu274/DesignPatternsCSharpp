using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.SOLID
{
    // BAD: Modifying class to add new shapes
    public class AreaCalculator_Bad
    {
        public double TotalArea(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle r)
                    area += r.Width * r.Height;
                else if (shape is Circle c)
                    area += Math.PI * c.Radius * c.Radius;
                // Need to modify if new shape added!
            }
            return area;
        }
    }

    // GOOD: Use polymorphism
    public interface IShape
    {
        double Area();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area() => Width * Height;
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area() => Math.PI * Radius * Radius;
    }

    public class AreaCalculator
    {
        public double TotalArea(IShape[] shapes)
        {
            double area = 0;
            foreach (var s in shapes)
                area += s.Area();
            return area;
        }
    }

    public static class OpenClosedPrinciple
    {
        public static void Run()
        {
            IShape[] shapes = {
                new Rectangle { Width = 2, Height = 3 },
                new Circle { Radius = 1 }
            };

            var calc = new AreaCalculator();
            Console.WriteLine($"Total Area: {calc.TotalArea(shapes)}");
        }
    }
}
