using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.SOLID
{
    // BAD: One big interface
    public interface IWorker_Bad
    {
        void Work();
        void Eat();
    }

    public class Robot_Bad : IWorker_Bad
    {
        public void Work() => Console.WriteLine("Robot working");
        public void Eat() => throw new NotImplementedException(); // robots don't eat!
    }

    // GOOD: Split interfaces
    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }

    public class HumanWorker : IWorkable, IFeedable
    {
        public void Work() => Console.WriteLine("Human working");
        public void Eat() => Console.WriteLine("Human eating");
    }

    public class Robot : IWorkable
    {
        public void Work() => Console.WriteLine("Robot working");
    }

    public static class InterfaceSegregation
    {
        public static void Run()
        {
            IWorkable robot = new Robot();
            IWorkable human = new HumanWorker();
            IFeedable feedable = new HumanWorker();

            robot.Work();
            human.Work();
            feedable.Eat();
        }
    }
}
