// /*
// 8. Wrtie C# method that count total males, females and others, given the array of genders as:
//     ```csharp
//     char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
//     ```
// */

using System;

public class GenderCount
{
    
    public void count(){

    char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
    int male,female,others;
    male=female=others=0;
    // or use for (int i = 0; i < genderCollection.Length; i++)
    foreach (var i in genderCollection)
    {
         
        if(i=='F')
        {
            female++;
        }
        else if (i=='M')
        {
            male++;
        }
        else {
            others++;

        }

    }
    Console.WriteLine($"Total Female:{female}");
    Console.WriteLine($"Total Male:{male}");
    Console.WriteLine($"Others:  {others}");



    }
}


