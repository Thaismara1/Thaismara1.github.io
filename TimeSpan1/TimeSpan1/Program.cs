using System;

class Program
{
    static void Main(string[] args)
    {
        var stopwatch = new Stopwatch ();
        stopwatch.Start = 10;
        stopwatch.Stop = 20;

        Console.WriteLine(stopwatch.TimeSpend);

    }
}