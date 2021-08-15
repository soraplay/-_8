using System;

namespace Урок_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var kort = (10, "word", 15);
            Console.WriteLine(kort.Item1);
            kort.Item1 = 100;
            Console.WriteLine(kort.Item1);
            Console.WriteLine(kort.Item2);
            Console.WriteLine(kort.Item3);
            Console.WriteLine();
            var kort2 = (name: "Vladimir", age: 20);
            Console.WriteLine(kort2.name);
            Console.WriteLine(kort2.age);

            (int, string) data = (1, "Oleksey");
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine();
            Console.WriteLine($"ID: {data.Item1}, Name: {data.Item1}");
        }
    }
}
