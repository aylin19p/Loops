using System;
using System.Net.Mail;

public class Program
{
    static void Main()
    {
        Checks();
    }

    private static void Checks()
    {
        string cmd = Console.ReadLine();
        if (cmd == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = GetMax(a, b);
            Console.WriteLine(res);
        }
        else if (cmd == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char res = GetMax(a, b);
            Console.WriteLine(res);
        }
        else if (cmd == "string")
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string res = GetMax(a, b);
            Console.WriteLine(res);
        }
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
    static char GetMax(char a, char b)
    {
        return a > b ? a : b;
    }
    static string GetMax(string a, string b)
    {
        return string.Compare(a, b) > 0 ? a : b;
    }
}