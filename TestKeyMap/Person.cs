using System;

namespace TestKeyMap
{
    internal partial class Program
    {
        internal partial class Person
        {
            public string N { get; set; }
            public int A { get; set; }

            public Person(string n, int a)
            {
                N = n;
                A = a + 1;
            }


            public override string ToString()
            {
                return $"{N} - {A}";
            }
        }
    }
}