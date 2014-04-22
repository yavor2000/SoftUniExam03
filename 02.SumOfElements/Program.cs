/* Problem 2. Sum of elements
 */

using System;

class Program
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        int[] num = new int[str.GetLength(0)];
        long sumAll = 0;
        long diff = long.MaxValue;
        for (int i = 0; i < num.GetLength(0); i++)
        {
            num[i] = int.Parse(str[i]);
            sumAll += num[i];
        }
        for (int i = 0; i < num.GetLength(0); i++)
        {
            if (num[i] == sumAll - num[i]) { Console.WriteLine("Yes, sum={0}", num[i]); return; }
            if (diff>Math.Abs(num[i]-(sumAll-num[i]))) diff=Math.Abs(num[i]-(sumAll-num[i]));
        }
        Console.WriteLine("No, diff={0}", diff);
    }
}