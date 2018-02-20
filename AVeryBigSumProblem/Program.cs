using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



class Solution
{

    static long aVeryBigSum(int n, long[] ar)
    {

        Int64 sum = 0;
        // Complete this function
        for(n = 0; n < ar.Length; n++)
        {
            sum += ar[n];
        }
        return sum;

        


    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
        long result = aVeryBigSum(n, ar);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
