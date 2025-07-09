using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.SOLID
{
    // Abstraction
    public interface IMessageService
    {
        void Send(string msg);
    }

    // Low-level module
    public class EmailService : IMessageService
    {
        public void Send(string msg) => Console.WriteLine($"Email sent: {msg}");
    }

    public class SMSService : IMessageService
    {
        public void Send(string msg) => Console.WriteLine($"SMS sent: {msg}");
    }

    // High-level module
    public class Notification
    {
        private readonly IMessageService _service;

        public Notification(IMessageService service) => _service = service;

        public void Notify(string msg) => _service.Send(msg);
    }

    public static class DependencyInversion
    {
        public static void Run()
        {
            IMessageService service = new EmailService();
            var notification = new Notification(service);
            notification.Notify("Hello!");

            service = new SMSService();
            notification = new Notification(service);
            notification.Notify("Hello again!");
        }
    }
}
