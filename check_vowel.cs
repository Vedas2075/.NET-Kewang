//2. Write a C# program to check if entered alphabet is vowel or not?
using System;
namespace vowel{

public class alphabet_check{

    public static void check_vowel()
    {
            char UserInput;
            Console.WriteLine("Enter alphabet to check vowel or not: ");
            UserInput= Console.ReadLine()[0];

    // char[] UserInput= UserInput1.ToCharArray();
    // char[] alpha={'a','A','e','E','i','I','o','O','u','U'};
    // foreach (char i in alpha) {}
        
        // or u cam use  Equals('') method 

                if (UserInput=='a' || UserInput=='A')
                {
                        Console.WriteLine($"User Entered vowel '{UserInput}' ");
                }
                else if(UserInput=='e' || UserInput =='E')
                {
                        Console.WriteLine($"User Entered vowel '{UserInput}'");
                }   
                else if(UserInput=='i'||UserInput=='I')
                {
                 Console.WriteLine($"User Entered vowel '{UserInput}'");

                }   
                else{
                    Console.WriteLine("Alphabet is not vowel");

                }  
            }

             
    }
    
  }



