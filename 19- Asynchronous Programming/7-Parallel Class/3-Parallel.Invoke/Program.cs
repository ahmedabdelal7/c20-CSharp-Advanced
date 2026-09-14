/*
using System;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Parallel.Invoke(
            () => Console.WriteLine($"Action 1 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 2 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 3 on thread {Task.CurrentId}")
        );

        Console.ReadKey();
    }
}
*/



using System;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Run the functions in parallel
        Console.WriteLine("Starting parallel functions.");
        Parallel.Invoke(Function1, Function2, Function3);
        Console.WriteLine("All parallel functions are completed.");
    }


    static void Function1()
    {
        Console.WriteLine("Function 1 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 1 is completed.");
    }


    static void Function2()
    {
        Console.WriteLine("Function 2 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 2 is completed.");
    }


    static void Function3()
    {
        Console.WriteLine("Function 3 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 3 is completed.");
    }
}