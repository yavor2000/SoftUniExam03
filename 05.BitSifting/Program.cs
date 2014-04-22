/* Problem 5. Bit Sifting
 */

using System;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong[] sieve = new ulong[n];
        for (int i = 0; i < n; i++)
        {
            sieve[i] = ulong.Parse(Console.ReadLine());
            number = number & (~(number & sieve[i]));
        }
        Console.WriteLine(countOnes(number));
    }
    static int countOnes(ulong n)
    {
        int count = 0;
        while (n > 0)
        {
            if ((n & 1) == 1) count++;
            n /= 2;
        }
        return count;
    }
}