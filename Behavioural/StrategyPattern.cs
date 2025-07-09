using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Behavioural
{
    // Strategy Interface
    public interface ISortStrategy
    {
        void Sort(int[] numbers);
    }

    // Concrete Strategies
    public class BubbleSort : ISortStrategy
    {
        public void Sort(int[] numbers)
        {
            Console.WriteLine("Sorting using Bubble Sort");
            // (Skip actual sort for simplicity)
        }
    }

    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] numbers)
        {
            Console.WriteLine("Sorting using Quick Sort");
            // (Skip actual sort for simplicity)
        }
    }

    // Context
    public class Sorter
    {
        private ISortStrategy _strategy;

        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sort(int[] numbers)
        {
            _strategy.Sort(numbers);
        }
    }

    public static class StrategyPattern
    {
        public static void Run()
        {
            // This example demonstrates the Strategy Pattern by allowing different sorting algorithms to be used interchangeably.
            // The Sorter class can switch between different sorting strategies (BubbleSort, QuickSort) at runtime.

            Console.WriteLine("Running Strategy Pattern Example:");
            var sorter = new Sorter();

            sorter.SetStrategy(new BubbleSort());
            sorter.Sort(new[] { 3, 1, 2 });

            sorter.SetStrategy(new QuickSort());
            sorter.Sort(new[] { 3, 1, 2 });
        }
    }
}
