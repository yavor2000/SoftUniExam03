/* Problem 4. Magic String
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] bukvi = { 'k', 'n', 'p', 's' };
        int[] teglo = { 1, 4, 5, 3 };
        int size = bukvi.GetLength(0);
        int count = 0;
        StringBuilder answer = new StringBuilder();
        for (int d1 = 0; d1 < size; d1++)
            for (int d2 = 0; d2 < size; d2++)
                for (int d3 = 0; d3 < size; d3++)
                    for (int d4 = 0; d4 < size; d4++)
                        for (int d5 = 0; d5 < size; d5++)
                            for (int d6 = 0; d6 < size; d6++)
                                for (int d7 = 0; d7 < size; d7++)
                                    for (int d8 = 0; d8 < size; d8++)
                                    {
                                        int left = teglo[d1] + teglo[d2] + teglo[d3] + teglo[d4];
                                        int right = teglo[d5] + teglo[d6] + teglo[d7] + teglo[d8];
                                        if (Math.Abs(left - right) == diff)
                                        {
                                            answer.Append(bukvi[d1]);
                                            answer.Append(bukvi[d2]);
                                            answer.Append(bukvi[d3]);
                                            answer.Append(bukvi[d4]);
                                            answer.Append(bukvi[d5]);
                                            answer.Append(bukvi[d6]);
                                            answer.Append(bukvi[d7]);
                                            answer.Append(bukvi[d8]);
                                            Console.WriteLine(answer);
                                            count++;
                                            answer.Remove(0,8);
                                        }
                                    }
        if (count == 0) Console.WriteLine("No");
    }
}