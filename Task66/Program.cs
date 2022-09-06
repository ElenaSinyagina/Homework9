// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSumNaturalNumber(int m, int n) 
{ 
    if (n == m) return n;
    return m + PrintSumNaturalNumber(m + 1, n);
} 
Console.WriteLine("Введите число M:");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}
Console.WriteLine("Введите число N:");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Сумма равна: " + PrintSumNaturalNumber(m, n));
