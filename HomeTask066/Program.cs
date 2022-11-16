// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// (НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ResultNumbers(int m, int n)
{
    if (n == m)                                                 
        return n;
    return ResultNumbers(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));