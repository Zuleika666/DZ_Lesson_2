/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end +1);
    return number;
}

int ThridDigit(int number)
{
    while(number>=1000)
    {
        number = number / 10;
        
    }
    int dig3 = number % 10;
    return dig3;
}

int random_num = GetNumberFromRange(1, 999999);

if (random_num<100)
{
    Console.WriteLine($"третьей цифры нет в числе {random_num} нет");
}
else
{
   int thr_dig = ThridDigit(random_num);
   Console.WriteLine($"Третьей цифрой числа {random_num} является {thr_dig}");
}
