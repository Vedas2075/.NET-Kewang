
using System;
public class ExceptionHandling
{

    public double compute(double x ,double y, double z)
    {
        double c=0;

        try
        {
            if(x==0 || y==0)
                throw new Exception ("Parameter value 0 ");

        double value = (x+y)/z;
        double c= value*x/(y+z);
        }

        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (c==0)
               c=20;
        }
        
        return c;

    }

    public void Test()
    {
        var c =compute(23,45,0);
        
    }


}
