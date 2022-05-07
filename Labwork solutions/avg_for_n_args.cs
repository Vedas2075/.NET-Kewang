/* 7. Modify same method(Question no.6) above that allows user to supply any number of argumnets 
and calculate average of all.
*/


using System;

public class AverageNum_nArgs
{
    // 1.sum array of numbers.
    // 2.calculate average & return it.
     public  double  average_calc(params double[] numbers  )
    {
        double sum=0;double average;
        for (int i = 0; i < numbers.Length; i++)
   {
       sum+=numbers[i];
  
   }
        
     average = sum / numbers.Length;
     return average;

    }

//  1.Take inputs from the user 
//  2.store in array of double & return it.
 public double[] get_input()
  { 
    Console.WriteLine("Number of Values you want to input: ");
    int n =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Values : ");
    double[] Values= new double[n];

    for(int i=0;i<Values.Length;i++)
    {
       Values[i]=Convert.ToDouble(Console.ReadLine());
    }
        return Values;
  }

// Dispaly the result
  public void showresult()
  { 
    double[] result= get_input();// call method  and store in double array .
    string s=Convert.ToString(average_calc(result));// convert average value(double) to string.
    Console.WriteLine("Average of numbers is "+ s);

  }
}