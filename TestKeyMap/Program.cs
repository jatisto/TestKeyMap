using System;

namespace TestKeyMap
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Nik", 15);
            Console.WriteLine($"{person.ToString()}");
            Console.WriteLine($"Hell Hllo {person.ToString()}");
            Console.ReadKey();
        }
    }
}