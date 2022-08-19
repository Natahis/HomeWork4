// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumLast(int num)
{
    if (number < 0) num = num * -1;
    int last = 0;
    int sum = 0;

    while (num > 0)
    {
        last = num % 10;
        num = num / 10;
        sum = sum + last;
    }
    return sum;
}

int result = SumLast(number);
Console.WriteLine($"Сумма цифр в заданном числе = {result}");

