using System;
public class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double s = Area(x, y);
        Console.WriteLine(s);
    }
    static double Area(double x, double y)
    {
        return x * y;
    }
}