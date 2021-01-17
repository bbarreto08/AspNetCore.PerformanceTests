using CoffeeTask.Services;
using System;
using System.Diagnostics;

namespace CoffeeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            // Preparando café da manhã usando Threads
            new CoffeeAsyncService().PrepareAsyncCoffee();
            stopwatch.Stop();
            Console.WriteLine($"Tempo passado - Café usando threads: {stopwatch.Elapsed}");

            stopwatch.Restart();


            // Preparando café sem uso de threads
            new CoffeeService().PrepareCoffee();

            stopwatch.Stop();
            Console.WriteLine($"Tempo passado - Café sem threads: {stopwatch.Elapsed}");

            Console.Read();
        }

    }
}
