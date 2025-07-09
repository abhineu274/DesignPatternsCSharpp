namespace DesignPatternsCSharpp.Creational
{
    // Abstract Products
    public interface IPetAnimal
    {
        void Speak();
    }

    public interface IWildAnimal
    {
        void Growl();
    }

    // Concrete Products
    public class Dog : IPetAnimal
    {
        public void Speak() => Console.WriteLine("Dog says: Woof!");
    }

    public class Tiger : IWildAnimal
    {
        public void Growl() => Console.WriteLine("Tiger growls: Grrr!");
    }

    // Abstract Factory
    public interface IAnimalFactory
    {
        IPetAnimal CreatePet();
        IWildAnimal CreateWild();
    }

    // Concrete Factory
    public class LandAnimalFactory : IAnimalFactory
    {
        public IPetAnimal CreatePet() => new Dog();
        public IWildAnimal CreateWild() => new Tiger();
    }
    internal class AbstractFactory
    {
        public static void Run()
        {
            IAnimalFactory factory = new LandAnimalFactory();

            IPetAnimal pet = factory.CreatePet();
            IWildAnimal wild = factory.CreateWild();

            pet.Speak();
            wild.Growl();
        }
    }
}
