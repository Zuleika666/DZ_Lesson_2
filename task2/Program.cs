/*
Напишите программу, которая вывдит случайное трехзначное число и удаляет вторую цифру этого числа 
Нпример 456 -> 46
*/

Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end +1);
    return number;
}

int DeleteSecondDigit(int number)
{
    int dig3 = number % 10;
    int dig1 = number / 100;
    int digits = dig1 * 10 + dig3;
    return digits;
}

int randomNumber = GetNumberFromRange(100, 999);
int digits2 = DeleteSecondDigit(randomNumber);
Console.WriteLine($"Из числа {randomNumber} получилось {digits2}");