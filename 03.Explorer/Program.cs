/* Problem 3. The Explorer
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder line = new StringBuilder();
        line.Append('-', n);
        int dir = 1;
        int left = n / 2;
        int right = n / 2;
        for (int i = 0; i < n; i++)
        {
            line[left] = '*';
            line[right] = '*';
            Console.WriteLine(line);
            line[left] = '-';
            line[right] = '-';
            if (left==0) dir = -1;
            left -= dir;
            right += dir;
            //start += dir;
        }
    }
}