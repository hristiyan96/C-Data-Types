using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double metres = double.Parse(Console.ReadLine());
        double kilometres = metres / 1000;
        Console.WriteLine($"{kilometres:f2}");
    }
}