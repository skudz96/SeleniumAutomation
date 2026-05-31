using System.Diagnostics;

namespace CSharpFundamentals
{
    // example of inheritance, program class inherits from program 3
    class Program : Program3
    {
        string name;
        // construcor is a method which will call by default when you create an object
        public Program(string name)
        {
            this.name = name;
        }

        public void getName()
        {
            Console.WriteLine("My name is " + this.name);
        }
        static void Main()
        {
            Debug.WriteLine("Hello, World!");
            int a = 4;
            Console.WriteLine("number is " + a);

            string name = "Serge";
            Console.WriteLine($"Hello, {name}!");

            Program p = new Program("Serge");
            p.getData();
            p.SetData();
        }

        public void getData()
        {
            Console.WriteLine("method test");
        }
    }
}