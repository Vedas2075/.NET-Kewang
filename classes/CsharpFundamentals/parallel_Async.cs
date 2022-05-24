using System;
using System.Threading;
using System.Diagnostics;


// Parallelism
public class Parallelism
{
    static short[] numbers = { 23, 56, 90, 64, 34, 21, 567, 23, 56, 90, 64, 34, 21, 567, 23, 56, 90, 64, 34, 21, 567 };

    public static void Main1()
    {
        
        // Stopwatch watch = new Stopwatch();

        // watch.Start();
        // TestSequential();
        // Console.WriteLine($"Sequential version took: {watch.ElapsedMilliseconds} ms");

        // watch.Restart();
        // TestParallel();
        // Console.WriteLine($"Parallel version took: {watch.ElapsedMilliseconds} ms");
    }

    public static void TestSequential()
    {
        foreach (short item in numbers)
        {
            CheckIfItsPrime(item);
        }
    }

    public static void TestParallel()
    {
        // TPL (Task Parallel Library)
        Parallel.ForEach(numbers, item =>
        {
            CheckIfItsPrime(item);
        });
    }

    // Simlating for 1 sec delay
    public static void CheckIfItsPrime(short itemNumber)
    {
        Console.WriteLine($"Processing for item {itemNumber}");
        Thread.Sleep(1000);
    }
}

public class Asynchronous
{
    private readonly HttpClient _httpClient = new HttpClient();
    public async Task DownloadText()
    {
        var stringData = await _httpClient.GetStringAsync("https://raw.githubusercontent.com/shaosh/SQLZoo/master/SQL%20Exercise/Nobel%20Quiz.txt");
        Console.WriteLine(stringData);
    }
}

