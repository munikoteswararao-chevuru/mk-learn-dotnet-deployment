using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from .NET!");
            await Task.Delay(-1);
        }
    }
}
