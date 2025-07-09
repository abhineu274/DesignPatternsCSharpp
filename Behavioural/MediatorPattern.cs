using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Behavioural
{
    // Mediator Interface
    public interface IChatRoom
    {
        void Register(User user);
        void SendMessage(string from, string to, string message);
    }

    // Concrete Mediator
    public class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, User> _users = new();

        public void Register(User user)
        {
            if (!_users.ContainsKey(user.Name))
                _users[user.Name] = user;

            user.SetChatRoom(this);
        }

        public void SendMessage(string from, string to, string message)
        {
            if (_users.ContainsKey(to))
            {
                _users[to].Receive(from, message);
            }
        }
    }

    // Colleague
    public class User
    {
        public string Name { get; }
        private IChatRoom _chatRoom;

        public User(string name) => Name = name;

        public void SetChatRoom(IChatRoom chatRoom) => _chatRoom = chatRoom;

        public void Send(string to, string message)
        {
            Console.WriteLine($"{Name} sends to {to}: {message}");
            _chatRoom.SendMessage(Name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"{Name} received from {from}: {message}");
        }
    }

    public static class MediatorPattern
    {
        public static void Run()
        {
            //Mediator Pattern is being used here
            //It is used to reduce the complexity of communication between objects
            //Here, the ChatRoom acts as a mediator between User objects
            //Users communicate through the ChatRoom instead of directly with each other


            Console.WriteLine("Running Mediator Pattern Example:");
            IChatRoom chatRoom = new ChatRoom();

            var alice = new User("Alice");
            var bob = new User("Bob");
            var charlie = new User("Charlie");

            chatRoom.Register(alice);
            chatRoom.Register(bob);
            chatRoom.Register(charlie);

            alice.Send("Bob", "Hi Bob!");
            bob.Send("Alice", "Hey Alice!");
            charlie.Send("Alice", "Hello Alice!");
        }
    }
}
