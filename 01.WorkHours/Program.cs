/* Problem 1. Work Hours
 */

using System;

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());
        double prod = double.Parse(Console.ReadLine());
        double answer = 0;
        int ans = 0;
        answer = days*0.9;
        answer *= 12.0;
        answer *= (prod/100.0);
        ans = (int)Math.Truncate(answer);
        /*
        if (Math.Truncate(hours) >= Math.Truncate(answer)) Console.WriteLine("Yes\n{0}",Math.Truncate(hours-answer));
        else Console.WriteLine("No\n{0}", Math.Truncate(hours - answer));*/
        if (hours <= ans) Console.WriteLine("Yes\n{0}", ans - hours);
        else Console.WriteLine("No\n{0}", ans - hours);
    }
}