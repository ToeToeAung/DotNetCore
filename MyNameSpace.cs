using System;

namespace MyNamespace
{
    // Declare a delegate
    public delegate void MyDelegate(string message);

    // Define an interface
    public interface IMyInterface
    {
        void Print();
    }

    // Define a structure that implements the interface
    public struct MyStruct : IMyInterface
    {
        public int Id;
        public string Name;

        // Implement the Print method from IMyInterface
        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }

    // Class that uses the delegate
    public class MyClass
    {
        // A method that matches the signature of the delegate
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
