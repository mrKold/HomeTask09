// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


 // Функция
 
string ResultNumbers(int n)
{
    if (n == 1)                                                 
        return "1";
    return ResultNumbers(n - 1) + ", " + Convert.ToString(n);
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(n));



// Процедура
void ResultNumbers(int n, int j)
{
    if (n == j)
        Console.Write($" {n} ");
    else
    {
        Console.Write($" {j} ");
        ResultNumbers(n, ++j);
    }
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), j = 1;
ResultNumbers(n, j);