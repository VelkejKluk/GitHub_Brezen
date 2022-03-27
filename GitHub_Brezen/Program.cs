using System;
 



//zadání čísel
Console.Write("Zadejte 1. číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Zadejte 2. číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());

if (cislo1 == cislo2)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Čísla jsou shodná...");
    Console.ResetColor();
    

}
else
{
    //nekonečný cyklus
    while (true)
    {
        //seřazení čísel podle uživat. inputu
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Chcete čísla seřadit od největšího po nejmenší (X), nebo opačně (Y)? X/Y: ");
        string input = Console.ReadLine().ToLower();
        Console.ResetColor();
        Console.WriteLine();


        if (input == "x")
        {
            //podmínky pokud je input x
            if (cislo1 > cislo2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Číslo jdou od největšího po nejmenší:");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"1. číslo = {cislo1}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"2. číslo = {cislo2}");
                Console.ResetColor();
            }
            else if (cislo1 < cislo2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Číslo jdou od největšího po nejmenší:");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"2. číslo = {cislo2}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"1. číslo = {cislo1}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Čísla jsou shodná...");
                Console.ResetColor();

            }
            break;

        }
        else if (input == "y")
        {
            //podmínky pokud je input y
            if (cislo1 > cislo2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Číslo jdou od nejmenšího po největší:");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"2. číslo = {cislo2}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"1. číslo = {cislo1}");
                Console.ResetColor();
            }
            else if (cislo1 < cislo2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Číslo jdou od nejmenšího po největší:");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"1. číslo = {cislo1}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"2. číslo = {cislo2}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Čísla jsou nejspíš shodná...");
                Console.ResetColor();

            }
            break;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Zadaná neplatná hodnota. Zaejte prosím znovu...");
            Console.ResetColor();
            continue;
        }



    }
}

