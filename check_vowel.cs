//2. Write a C# program to check if entered alphabet is vowel or not?

using System;

public class alphabet_check{

    public  void check_vowel()
    {
               Console.WriteLine("Enter alphabet to check vowel or not: ");  
               bool result = Char.TryParse(Console.ReadLine(), out char UserInput);

                while (result)

                {
               // or u cam use  Equals('') method 

                if (UserInput=='a' || UserInput=='A')
                {
                        Console.WriteLine($"User Entered vowel '{UserInput}' ");
                        break;
                }
                else if(UserInput=='e' || UserInput =='E')
                {
                        Console.WriteLine($"User Entered vowel '{UserInput}'");
                        break;
                }   
                else if(UserInput=='i'||UserInput=='I')
                {
                 Console.WriteLine($"User Entered vowel '{UserInput}'");
                 break;

                }   
                else if(UserInput=='o'||UserInput=='O')
                {
                 Console.WriteLine($"User Entered vowel '{UserInput}'");
                 break;

                }   
                else if(UserInput=='u'||UserInput=='U')
                {
                 Console.WriteLine($"User Entered vowel '{UserInput}'");
                 break;

                }   
                else {
                     Console.WriteLine("Alphabet is not Vowel. ");
                     break;
                }
                
                }  

       }
}        






    // char[] UserInput= UserInput1.ToCharArray();
    // char[] alpha={'a','A','e','E','i','I','o','O','u','U'};
    // foreach (char i in alpha) {}
    //user= Regex.IsMatch(input, @"^[a-zA-Z]+$");


