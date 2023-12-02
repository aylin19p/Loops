using System;
public class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        PrintTriangle(input);
    }
    static void PrintLine( int end) 
    {
        for (int j = 1; j <= end; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
    }
    static void PrintTriangle(int n )
    {
        for (int i = 1; i <= n; i++)
        {
          PrintLine(i);  
        }

        for (int i = n - 1; i > 0; i--)
        {
            PrintLine(i);
        }
    }
}