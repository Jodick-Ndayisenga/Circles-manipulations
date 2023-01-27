using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to circle calculations!!");
        Console.WriteLine(" ");
        Console.Write("Enter the radius of your circle: ");
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine($"The diameter is {radius * 2}");
        Console.WriteLine($"The circumference is {radius * 2 * 3.14}");
        Console.WriteLine($"The area is {radius * radius * 3.14}");
    }
}