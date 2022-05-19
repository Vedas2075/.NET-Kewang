using System;
using System.Threading;
using System.Diagnostics;


public class Parallelism
{
    short[] numbers = {23,56,90,64,21};



    public static void TestSequential()
    {
        foreach (short item in numbers)
        {
            checkIfPrime(item);
        }
    }

     public static void Testparallel()
    {
       Parallel.foreach (short item in numbers)
        {
            checkIfPrime(item);
        }
    }

    public static void checkIfPrime(short itemNumber)
    {
        Console.WriteLine($"processing for item {itemNumber}");
        Thread.Sleep(1000);

    }


    public static void Main1()
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();
        Console.WriteLine($"Sequential version took :{watch.ElapsedMilliseconds} ms");

        watch.Restart();
        TestSequential();
        Console.WriteLine("Parallel");

    

    }


}


public class  Asynchronous
{



    private readonly HttpClient_httpClient = new HttpClient();

    public async Task DownloadText()
    {
        var stringData = await_httpClient.GetStringAsync("url");
        Console.WriteLine(stringData);

    }
}