// 6. Write C# method that calculate average of 3 decimal number arguments.


public class AverageNum
{
    
     public  double  average_calc(double a,double b,double c)
    {
        return  (a+b+c)/3;
    }
 
  public void showresult()
  { 
    Console.WriteLine("Enter First decimal number: ");
    double a  =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Second decimal number: ");
    double b  =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Third decimal number: ");
    double c  =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(average_calc(a,b,c));
  }

}