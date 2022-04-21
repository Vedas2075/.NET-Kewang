// Console.Write("Hey There!");

// Methods m1 = new();
// var s = m1.Sum();

// s = m1.Sum(23,4,56.7);
// s = m1.Sum(34.2);
// s = m1.Sum(2.3, 4.6, 12.4);

// var x =m1.Greet("Kewang","Limbu","Dr.");
// x=m1.Greet("Kewang","Limbu");
// Console.WriteLine(x);

using ABC;
public class Program
{

    public static void Main()
    {
       Calculator calculator1 =new();
       calculator1.operand1=34.5;
       calculator1.operand2=35.6;

       var add =calculator1.Sum();
       var minus=calculator1.Subtract();
       var mul =calculator1.Multiply();
       var div= calculator1.Divide();


       Calculator calculator2= new(34.6,35.6);

       var add2 =calculator2.Sum();
       var minus2=calculator2.Subtract();
       var mul2 =calculator2.Multiply();
       var div2= calculator2.Divide();


    }
}