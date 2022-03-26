using System;

Console.Write("Zadejte 1. číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Zadejte 2. číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());

if (cislo1 > cislo2)
{
    Console.WriteLine("Číslo jdou od největšího po nejmenší:");
    Console.WriteLine();
    Console.WriteLine($"1. číslo = {cislo1}");
    Console.WriteLine($"2. číslo = {cislo2}");
}
else if (cislo1 < cislo2)
{
    Console.WriteLine("Číslo jdou od největšího po nejmenší:");
    Console.WriteLine();
    Console.WriteLine($"2. číslo = {cislo2}");
    Console.WriteLine($"1. číslo = {cislo1}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Čísla jsou shodná...");
    Console.ResetColor();

}