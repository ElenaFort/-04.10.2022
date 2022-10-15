/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

void GetNumber(int day)
{
    if (day > 0 & day < 6)
        Console.WriteLine($"{day} - будний день");
    else if (day >= 6 & day <= 7)
        Console.WriteLine($"{day} - выходной день");
    else

        Console.WriteLine($"{day} - число не обозначает день недели");
}
GetNumber(7);
