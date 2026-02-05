using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1");
        Console.Write("Enter A: ");
        int NumberA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter N: ");
        int PowerNumberA = Convert.ToInt32(Console.ReadLine());

        int Power = 1;
        for (int ResultTaskOne = 0; ResultTaskOne < PowerNumberA; ++ResultTaskOne) Power *= NumberA;
        Console.WriteLine($"{NumberA}^{PowerNumberA} = {Power}");

        Console.WriteLine("\nTask 2");
        Console.Write("Enter x (>=100): ");
        int NumberX = Convert.ToInt32(Console.ReadLine());

        int temp = NumberX;
        int Digits = 0;
        while (temp > 0) { temp /= 10; ++Digits; }

        int SecondDigitNumber = (NumberX / (int)Math.Pow(10, Digits - 2)) % 10;
        int firstDigitNumber = NumberX / (int)Math.Pow(10, Digits - 1);
        int NumbersExceptFirstTwo = NumberX % (int)Math.Pow(10, Digits - 2);
        int OriginalNumberWithoutSecond = firstDigitNumber * (int)Math.Pow(10, Digits - 2) + NumbersExceptFirstTwo;
        int ResultTaskTwo = OriginalNumberWithoutSecond * 10 + SecondDigitNumber;

        Console.WriteLine($"x = {NumberX}");
        Console.WriteLine($"Result n = {ResultTaskTwo}");
    }
}