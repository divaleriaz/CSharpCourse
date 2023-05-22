using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;

        Console.WriteLine(number1);
        Console.WriteLine(number2);

        number2 = 8;

        Console.WriteLine(number2);

        number1 = 4;

        Console.WriteLine(number1);

        int number3 = number1 + number2;

        Console.WriteLine(number3);

        int number4 = number1 * number2 + number3;

        Console.WriteLine(number4);

    }
}