using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Behavioural
{
    // Command Interface
    public interface ICommand
    {
        void Execute();
    }

    // Receiver
    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light is ON");
        public void TurnOff() => Console.WriteLine("Light is OFF");
    }

    // Concrete Commands
    public class TurnOnCommand : ICommand
    {
        private readonly Light _light;

        public TurnOnCommand(Light light) => _light = light;

        public void Execute() => _light.TurnOn();
    }

    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffCommand(Light light) => _light = light;

        public void Execute() => _light.TurnOff();
    }

    // Invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void PressButton() => _command.Execute();
    }

    public static class CommandPattern
    {
        public static void Run()
        {
            // Here, we demonstrate the Command Pattern by creating a simple remote control that can turn a light on and off.
            // The remote control acts as the invoker, while the light is the receiver.
            // Concrete commands (TurnOnCommand and TurnOffCommand) encapsulate the actions to be performed on the light.

            Console.WriteLine("Running Command Pattern Example:");
            var light = new Light();
            var remote = new RemoteControl();

            remote.SetCommand(new TurnOnCommand(light));
            remote.PressButton();

            remote.SetCommand(new TurnOffCommand(light));
            remote.PressButton();
        }
    }
    }
