//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого

Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end +1);
    return number;
}

int SecondDigit(int number)
{
    int dig2 = (number % 100) / 10;
    return dig2;
}

int random_num = GetNumberFromRange(100, 999);
int digit = SecondDigit(random_num);
Console.WriteLine($"Второй цифрой числа {random_num} является {digit}");
