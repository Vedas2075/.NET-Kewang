//1. Write a C# program to check if user says "Hi" or "Hello"?

   public class check
{
/*
public  static void greeting()
you can't access static members with instance syntax.
*/

public  void greeting()
{
           
         Console.WriteLine("Enter 'Hi' or 'Hello': ");
         string user_input = Console.ReadLine();
         var result= (user_input=="Hi" || user_input=="Hello") ? $"\nUser Greet saying '{user_input}'" : "\nPlease  entered again!";
         Console.WriteLine(result);
         
       }
   } 

