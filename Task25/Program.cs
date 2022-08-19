// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите два положительных числа больше 0: ");
Console.Write("A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());

int Power(int a,int b)
{
    int power = a;
    for (int i = 2; i <= b; i++)    
    {
        power = power * a;
    }   
    return power;
}

if (A > 0 && B > 0)
{
    int result = Power(A,B);
    Console.WriteLine($"Число {A} в степени {B} = {result}.");
}
else
{
Console.WriteLine("Некорректный ввод! ");
}

