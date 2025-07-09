namespace DesignPatternsCSharpp.Creational
{
    // Prototype Pattern

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person Clone()
        {
            // Simple shallow copy
            return (Person)this.MemberwiseClone();
        }
    }

    internal class PrototypePattern
    {
        public static void Run()
        {
            // Create an original person
            Person original = new Person { Name = "John", Age = 30 };
            // Clone the original person
            Person clone = original.Clone();
            // Modify the clone
            clone.Name = "Jane";
            clone.Age = 25;
            // Display both persons
            Console.WriteLine($"Original: {original.Name}, Age: {original.Age}"); // Output: Original: John, Age: 30
            Console.WriteLine($"Clone: {clone.Name}, Age: {clone.Age}"); // Output: Clone: Jane, Age: 25
        }
    }
}
