using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Structural
{
    public interface INotifier
    {
        void Send(string message);
    }

    // Concrete Component
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    // Decorator base class
    public abstract class NotifierDecorator : INotifier //This class allows wrapping of INotifier instances
    {
        protected INotifier _wrappee;

        protected NotifierDecorator(INotifier wrappee)
        {
            _wrappee = wrappee;
        }

        public virtual void Send(string message) //INotifier interface method made virtual to allow overriding in concrete decorators
        {
            _wrappee.Send(message);
        }
    }

    // Concrete Decorators
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier wrappee) : base(wrappee) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class PushNotifier : NotifierDecorator
    {
        public PushNotifier(INotifier wrappee) : base(wrappee) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Push Notification: {message}");
        }
    }

    public static class DecoratorPattern
    {
        public static void Run()
        {
            // This is a simple example of the Decorator Pattern in C#.
            // The Notifier interface defines a method for sending messages.
            // The EmailNotifier class implements this interface.
            // The NotifierDecorator class is an abstract class that wraps an INotifier instance.
            // Concrete decorators (SMSNotifier, PushNotifier) extend NotifierDecorator to add additional functionality.
            // In this example, we create an EmailNotifier and decorate it with SMSNotifier and PushNotifier.
            //[IMP] This allows us to send a message via email, SMS, and push notification without modifying the original EmailNotifier class.
            // The Decorator Pattern is useful for adding responsibilities to objects dynamically and can be used to extend the functionality of classes in a flexible way.

            Console.WriteLine("Decorator Pattern Example");
            INotifier notifier = new EmailNotifier(); //Create an EmailNotifier instance
            notifier = new SMSNotifier(notifier); //Wrap it with SMSNotifier - this adds SMS functionality
            notifier = new PushNotifier(notifier); //Wrap it with PushNotifier - this adds Push Notification functionality

            //PushNotifier-- > SMSNotifier-- > EmailNotifier
            //This is what notifier looks like now - It has wrapped the EmailNotifier with SMSNotifier and PushNotifier decorators.
            //When we call Send, it will go through all the decorators in reverse order.
            //These decorators can be stacked to add multiple functionalities without changing the original EmailNotifier class.

            notifier.Send("Hello, user!"); // This will send the message via Email, SMS, and Push Notification
        }
    }
}
