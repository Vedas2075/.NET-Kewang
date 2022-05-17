using System;
using System.Collections.Generic;

public class Collection
{
    // Simple array
    byte[] ages = { 23, 45, 67, 12, 20, 21, 43, 54, 76, 90 };

    // List
    List<string> names = new() { "sdfsf", "sdfsf", "sdfsfs" };
    // Stack
    Stack<decimal> marks = new();
    Queue<short> tokens = new();

    Dictionary<string, double> nameMarks = new()
    {
        ["Kewang"] = 45,
        ["Kewang1"] = 50,
        ["Kewang2"] = 40
    };

    void Test()
    {
        names.Add("Kewang");
        names.Remove("Kewang");
        var x = names.Contains("Ram");

        marks.Push(45.67m);
        var y = marks.Pop();

        nameMarks.Add("Ram", 12);

        Print<int>(56);
    }

    void Print<V>(V parameter)
    {
        Console.WriteLine(parameter);
    }
}
