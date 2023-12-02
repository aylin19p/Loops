using System;
public class Program
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        int pow = int.Parse(Console.ReadLine());
        double res =  RaisePower(num, pow);
        Console.WriteLine(res);
    }
    static double RaisePower(double num, int pow)
    {
         
        double res = Math.Pow(num, pow);
        return res;
    }
}