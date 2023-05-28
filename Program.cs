// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение: ");
int n = Convert.ToInt32(Console.ReadLine());
int vivod(int x)
{
    Console.Write(x + " ");
    if (x == 1) return 1;
    return vivod(x - 1);
}
vivod(n);


// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
{
    int a = m;
    m = n;
    n = a;
}
int summa(int x, int y)
{
    if (x == y) return y;
    return x + summa(x + 1, y);
}
Console.WriteLine(summa(n,m));