// 5. Write a C# program to calculate the sum of squares of first *n* natural numbers.
/*
formula:
1 + 2 + ……….. + n = n(n+1) / 2 
1^2 + 2^2 + ……… + n^2 = n(n+1)(2n+1) / 6
*/

using System;

public class SumoFSquare
{
    
     public  int  sum_result(int n)
    {
        return (n * (n + 1) *(2 * n + 1)) / 6;
    }
 
}
   