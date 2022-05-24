//Language Integrated Query(LINQ)
using System;
using System.collection.Generic;


using System.LINQ

public class Query
{
    byte[] numbers = {23,45,67,12,20,21,43,54,76,90};


    List <Person> people = new()
    {

        new Person {Name= "Ram",Address="Ktm",Gen="m"},
        new Person {Name= "Bikram",Address="Ktm",Gen="m"},
        new Person {Name= "Kumar",Address="lalitpur",Gen="m"},
        new Person {Name= "Kewang",Address="Gothgaun",Gen="m"},
        new Person {Name= "Harilaxmi",Address="Itahari",Gen="f"},
        new Person {Name= "bot",Address="Ktm",Gen="f"}

    };
    public void Test()
    {
        //List all odd numbers
    var oddNumbers = numbers.Where(numbers=>numbers%2!=0);
    

    // list all numbers greater than 50
    var numGreaterThan50= numbers.Where(x=>x > 50 && x%2 ==0);
    // or
    numGreaterThan50 = from num in numbers
                        Where num > 50 && num%2==0;
                        Select num;

    //Get squares of all elements 
    var numEachSquare = numbers.Select(y=>y*y);

    // check if collection  has number greater than 100
    var x = numbers.Any(x => x > 100);
    var y = numbers.All(x=> x >100);

    //skip and take

    var z = numbers.Skip(5).Take(4);


    //ordering the numbers in ascending

    var ordernum = numbers.OrderBy( x => x).Select(x => x);

    // Expression syntax
    var ordernum_2 =from number in numbers orderby x Select x;

// list num starting with H
// where n.StartsWith("H")
var females = people.Where(x => x.Name.toLower().StartsWith("h") && x.Gen=="f");

    var startName = from  name in Person 
                    Where name.Name[0]=='H'
                    Select name;

    }
}
