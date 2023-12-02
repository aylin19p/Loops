using System;
public class Program
{
    static void Main()
    {
        string cmd = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        if (cmd == "Add")
        {
            Add(n, m);
        }
        else if (cmd == "Multiply")
        {
            Multiply(n, m);
        }
        else if (cmd == "Subtract")
        {
            Subtract(n, m);
        }
        else if (cmd == "Divide")
        {
            Divide(n, m);
        }
    }
    public static void Add(int n, int m)
    {
        Console.WriteLine(n + m);
    }
    public static void Multiply(int n, int m)
    {
        int s = n * m;
        Console.WriteLine(s);
    }
    public static void Subtract(int n, int m)
    {
        int s = n - m;
        Console.WriteLine(Math.Abs(s));
    }
    public static void Divide(int n, int m)
    {
        Console.WriteLine(Math.Abs(n / m));
    }
}