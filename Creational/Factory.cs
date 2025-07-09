namespace DesignPatternsCSharpp.Creational
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Shape Clone();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

        public void Draw()
        {
            Console.WriteLine($"Circle at ({X}, {Y}) with radius {Radius}");
        }
    }
    internal class Factory
    {
        public static void Run()
        {
            Console.WriteLine("Running Factory Pattern Example:");
            // Create a Circle and clone it
            Circle circle1 = new Circle { X = 10, Y = 20, Radius = 5 };
            Circle circle2 = (Circle)circle1.Clone();
            circle2.X = 30; // Modify the cloned circle's position
            // Draw both circles
            circle1.Draw(); // Output: Circle at (10, 20) with radius 5
            circle2.Draw(); // Output: Circle at (30, 20) with radius 5
        }
    }
}
