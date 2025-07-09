using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using DesignPatternsCSharpp.Creational;
using DesignPatternsCSharpp.Structural;
using DesignPatternsCSharpp.Behavioural;
using DesignPatternsCSharpp.SOLID;

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

    //Structural Design Patterns
    //| Pattern          | Use When                                               |
    //| ---------------- | ------------------------------------------------------ |
    //| Adapter          | Interface mismatch between two classes                 |
    //| Bridge           | Separate abstraction from implementation                |
    //| Composite        | Tree structure of objects, treat individual and group uniformly |
    //| Decorator        | Add responsibilities to objects dynamically            |
    //| Facade           | Simplify complex subsystem with a unified interface    |
    //| Flyweight        | Share objects to support large numbers of similar objects |
    //| Proxy            | Control access to an object                             |

    //Behavioral Design Patterns
    //| Pattern          | Use When                                               |
    //| ---------------- | ------------------------------------------------------ |
    //| Chain of Responsibility | Multiple objects can handle a request, decouples sender and receiver |
    //| Command          | Encapsulate a request as an object, parameterize clients with queues, requests, and operations |
    //| Interpreter      | Define a language's grammar and use it to interpret sentences |
    //| Iterator         | Sequential access to elements of a collection without exposing its underlying representation |
    //| Mediator         | Define an object that encapsulates how a set of objects interact, promoting loose coupling |
    //| Memento          | Capture and restore an object's internal state without violating encapsulation |
    //| Observer         | One-to-many dependency between objects, notify observers of state changes |
    //| State            | Allow an object to alter its behavior when its internal state changes, appearing to change its class |
    //| Strategy         | Define a family of algorithms, encapsulate each one, and make them interchangeable |

    internal class Program
    {
        static void Main(string[] args)
        {
            //Creational Design Patterns examples
            //SingletonPattern.Run();
            //BuilderPattern.Run();
            //Factory.Run();
            //AbstractFactory.Run();
            //PrototypePattern.Run();

            //Factory vs Abstract Factory
            //Factory - defines an interface for creating an object, but lets subclasses decide which class to instantiate.
            //Abstract Factory - provides an interface for creating families of related or dependent objects without specifying their concrete classes.


            //Structural Design Patterns examples
            //AdapterPattern.Run();
            //DecoratorPattern.Run();
            //FacadePattern.Run();
            //CompositePattern.Run();




            //Behavioral Design Patterns examples
            //CommandPattern.Run();
            //MediatorPattern.Run();
            //StrategyPattern.Run();
            //ObserverPattern.Run();



            //SOLID Principles examples
            //SingleResponsibility.Run();
            //OpenClosedPrinciple.Run();
            //LiskovSubstitution.Run();
            //InterfaceSegregation.Run();
            DependencyInversion.Run();
        }
    }
}
