using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using DesignPatternsCSharpp.Creational;

namespace DesignPatternsCSharpp
{
    /*
     * Design Patterns: These are the best practices for software design that can be used to solve common problems in software development.
     * Types of Design Patterns:
     * 1. Creational Patters - Deals with object creation mechanisms, trying to create objects in a manner suitable to the situation.
     *                         Factory Method, Abstract Factory, Builder, Prototype, Singleton.
     * 2. Structural Patterns - Concerned with how classes and objects are composed to form larger structures.
     *                          Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy.
     * 3. Behavioral Patterns - Focus on communication between objects, what goes on between objects and how they operate together.
     *                          Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor.
     * 
     */

    //Creational Design Patterns
    //| Pattern          | Use When                                               |
    //| ---------------- | ------------------------------------------------------ |
    //| Singleton        | Single, global instance needed                         |
    //| Factory Method   | Class decides which subclass to instantiate            |
    //| Abstract Factory | Create families of related objects                     |
    //| Builder          | Complex object with many optional parts                |
    //| Prototype        | Copy existing objects instead of creating from scratch |

     internal class Program
    {
        static void Main(string[] args)
        {
            //Creational Design Patterns examples
            SingletonPattern.Run(); // Running Singleton Pattern example
            BuilderPattern.Run(); // Running Builder Pattern example
            Factory.Run(); // Running Factory Method Pattern example
            AbstractFactory.Run(); // Running Abstract Factory Pattern example
            PrototypePattern.Run(); // Running Prototype Pattern example

            //Factory vs Abstract Factory
            //Factory - defines an interface for creating an object, but lets subclasses decide which class to instantiate.
            //Abstract Factory - provides an interface for creating families of related or dependent objects without specifying their concrete classes.
        }
    }
}
