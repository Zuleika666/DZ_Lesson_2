// Напишите программу которая выводит случайное числоиз отрезка [10, 99] и показывает наибоьшую цифру числа
// Например 78 > 8
// 12 > 2,  85 > 8

Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end +1);
    return number;
}

int GetMaxDigit(int number)
{
    int max = number % 10;
    int dig2 = number / 10;
    if (max < dig2)
    {max = dig2;}
    
    return max;
}

int randomNumber = GetNumberFromRange(10, 99);
int maxDigit = GetMaxDigit(randomNumber);
Console.WriteLine($"Для числа {randomNumber} максимальной цифрой явл {maxDigit}");
