/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void GetNumber(int number)
{
    string Num = number.ToString();
    int n = Num.Length;
    if (n > 3)
    {
        int result = int.Parse(Num[2].ToString());
        Console.WriteLine($"Третья цифра числа {Num}: {result}");
    }
    else

        Console.WriteLine($"{Num}: в числе третьей цифры нет");
}
GetNumber(25463);
