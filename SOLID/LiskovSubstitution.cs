using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.SOLID
{
    // BAD: Square breaks Rectangle behavior
    public class Rectangle2
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area() => Width * Height;
    }

    public class Square_Bad : Rectangle2
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public static class LiskovSubstitution
    {
        public static void Run()
        {
            Rectangle2 r = new Rectangle2 { Width = 5, Height = 10 };
            Console.WriteLine($"Rectangle area: {r.Area()}"); // OK

            Rectangle2 s = new Square_Bad { Width = 5, Height = 10 }; // logically wrong!
            Console.WriteLine($"Square area: {s.Area()}"); // Oops: not 5*10 but 10*10
        }
    }
}
