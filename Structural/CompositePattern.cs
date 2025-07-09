using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Structural
{
    public interface IFileSystemItem
    {
        void Display(string indent = "");
    }

    // Leaf
    public class File : IFileSystemItem
    {
        private readonly string _name;

        public File(string name) => _name = name;

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- File: {_name}");
        }
    }

    // Composite
    public class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _children = new();

        public Folder(string name) => _name = name;

        public void Add(IFileSystemItem item) => _children.Add(item);

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ Folder: {_name}");
            foreach (var child in _children)
            {
                child.Display(indent + "   ");
            }
        }
    }

    public static class CompositePattern
    {
        public static void Run()
        {
            Console.WriteLine("Running Composite Pattern Example:");
            var root = new Folder("Root");
            var file1 = new File("File1.txt");
            var file2 = new File("File2.txt");

            var subFolder = new Folder("SubFolder");
            var subFile = new File("SubFile1.txt");

            root.Add(file1);
            root.Add(file2);
            root.Add(subFolder);

            subFolder.Add(subFile);

            root.Display();
        }
    }
}
