// 4. Write a C# program to find largest number among 3 numbers?

using System;

public class LargestNum
{

public void checkLargest()
{

    Console.WriteLine("-----Find the Largest Number Among Three Numbers----- ");
    Console.WriteLine("Enter first number: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter Second number: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter third number: ");
    double c = Convert.ToDouble(Console.ReadLine());

    var largest = a > b ? (a > c ? a : c) : (b > c ? b : c);

    Console.WriteLine(largest+" is the Largest.");

}

}