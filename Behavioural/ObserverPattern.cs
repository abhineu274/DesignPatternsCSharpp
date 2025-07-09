using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Behavioural
{
    // Subject
    public class NewsPublisher
    {
        private readonly List<IObserver> _subscribers = new();

        public void Subscribe(IObserver observer) => _subscribers.Add(observer);
        public void Unsubscribe(IObserver observer) => _subscribers.Remove(observer);

        public void Notify(string news)
        {
            foreach (var sub in _subscribers)
                sub.Update(news);
        }
    }

    // Observer Interface
    public interface IObserver
    {
        void Update(string news);
    }

    // Concrete Observer
    public class Subscriber : IObserver
    {
        private readonly string _name;

        public Subscriber(string name) => _name = name;

        public void Update(string news)
        {
            Console.WriteLine($"{_name} received news: {news}");
        }
    }

    public static class ObserverPattern
    {
        public static void Run()
        {
            //Here we demonstrate the Observer Pattern by creating a simple news publisher and subscribers.
            //The publisher notifies all subscribers when new news is published.
            //It is observed by multiple subscribers who react to the news updates.
            Console.WriteLine("Running Observer Pattern Example:");
            var publisher = new NewsPublisher();
            var sub1 = new Subscriber("Alice");
            var sub2 = new Subscriber("Bob");

            publisher.Subscribe(sub1);
            publisher.Subscribe(sub2);

            publisher.Notify("New Article Published!");
        }
    }
}
