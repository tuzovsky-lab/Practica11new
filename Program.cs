using System;
namespace Practica11new;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите X = ");
        double x = Convert.ToDouble(Console.ReadLine());
        double F= Math.Pow(x,2) + 5;
        Console.WriteLine($"F = {F}.");
        Console.ReadLine();
    }
}
