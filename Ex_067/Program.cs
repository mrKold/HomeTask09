// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ResultNumbers(int n)
{
    if (n/10 == 0) 
        return n;
    return ResultNumbers(n / 10) + n % 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(n));
