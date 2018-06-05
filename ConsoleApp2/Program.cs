using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 12;
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
