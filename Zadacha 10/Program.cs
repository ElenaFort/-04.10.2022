/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void GetNumber(int number)
{
    if (number < 1000 && number > 99)
    {
        int theFirstTwoDigits = number / 10;
        int secondDigil = theFirstTwoDigits % 10;

        Console.WriteLine($"Втарая цифра числа {number}: {secondDigil}");
    }
    else
        Console.WriteLine("Введено не трёхзначное число");
}
GetNumber(276);
