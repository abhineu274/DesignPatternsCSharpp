using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Structural
{
    public class CPU
    {
        public void Freeze() => Console.WriteLine("CPU Freeze");
        public void Jump(long position) => Console.WriteLine($"CPU Jump to {position}");
        public void Execute() => Console.WriteLine("CPU Execute");
    }

    public class Memory
    {
        public void Load(long position, byte[] data) =>
            Console.WriteLine($"Memory Load data at position {position}");
    }

    public class HardDrive
    {
        public byte[] Read(long lba, int size)
        {
            Console.WriteLine($"HardDrive Read {size} bytes at {lba}");
            return new byte[size];
        }
    }

    // Facade
    public class ComputerFacade
    {
        private readonly CPU _cpu;
        private readonly Memory _memory;
        private readonly HardDrive _hardDrive;

        public ComputerFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDrive = new HardDrive();
        }

        public void Start()
        {
            _cpu.Freeze();
            _memory.Load(0, _hardDrive.Read(0, 1024));
            _cpu.Jump(0);
            _cpu.Execute();
        }
    }

    public static class FacadePattern
    {
        public static void Run()
        {
            //Here, we demonstrate the Facade Pattern by creating a simple facade for a computer system.
            //The ComputerFacade class provides a simplified interface to start the computer,
            //hiding the complexities of the CPU, Memory, and HardDrive interactions.
            //Facade - provides a simplified interface to a complex subsystem.

            Console.WriteLine("Running Facade Pattern Example:");
            var computer = new ComputerFacade();
            computer.Start();
        }
    }
}
