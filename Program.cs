// int [,] matrix = new int[,]
// {
//     { 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0},
//     { 0 , 1 , 0 , 0 , 0 , 0 , 1 , 1 , 1},
//     { 0 , 1 , 1 , 1 , 1 , 1 , 1 , 0 , 1},
//     { 0 , 1 , 0 , 0 , 1 , 0 , 0 , 0 , 1},
//     { 0 , 1 , 0 , 0 , 1 , 0 , 0 , 0 , 1},
//     { 0 , 0 , 1 , 0 , 1 , 1 , 0 , 1 , 0},
//     { 0 , 0 , 1 , 0 , 1 , 0 , 0 , 1 , 0},
//     { 0 , 0 , 1 , 0 , 0 , 0 , 1 , 0 , 0},
//     { 0 , 0 , 0 , 1 , 0 , 0 , 1 , 0 , 0},
//     { 0 , 0 , 0 , 0 , 1 , 1 , 0 , 0 , 0}
// };

// void Pechat(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i,j] == 0) Console.Write("   ");
//             else Console.Write(" + ");
//         }
//         Console.WriteLine();
//     }
// }
// Pechat(matrix);
// int i = 1;
// void Zakrashivanie(int [,] matr, int stolb, int stroka)
// {   
//     if (matr[stolb, stroka] == 0)
//         {
//             matr[stolb, stroka] = 1;    
//             Console.WriteLine(i + " уровень");
//             i = i + 1;
//             string xxx = Console.ReadLine();
//             Pechat(matrix);
//             Zakrashivanie(matr, stolb - 1, stroka);
//             Zakrashivanie(matr, stolb , stroka - 1);
//             Zakrashivanie(matr, stolb + 1, stroka);
//             Zakrashivanie(matr, stolb, stroka + 1);
//             i--;
//             Console.WriteLine(i + " уровень");
//         }
// }
// Zakrashivanie(matrix, 6, 5);


double [,] RazmerTablici()
{
Console.Write("Введите высоту таблицы : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину таблицы : ");
int y = Convert.ToInt32(Console.ReadLine());
double [,] arr =new double[x , y];
return (arr);
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] matrix = (RazmerTablici());
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-50 , 50), 2);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число, которое хотите найти в таблице: ");
int k = Convert.ToInt32(Console.ReadLine());
double [,] matrica = (RazmerTablici());
int xx = 0;
string [] massivVivodov = {};
for (int i = 0; i < matrica.GetLength(0); i++)
{
    for (int j = 0; j < matrica.GetLength(1); j++)
    {
        matrica[i,j] = new Random().Next(10 , 100);
        Console.Write(matrica[i,j] + " ");
        if (matrica[i,j] == k) 
        {
            Array.Resize(ref massivVivodov, massivVivodov.Length + 1);
            massivVivodov[xx] = $"Число {k} есть в таблице в {i + 1} строке, в {j + 1} столбце";
            xx++;
        }
    }
    Console.WriteLine();
}
if (xx == 0) Console.WriteLine($"Числа {k} нет в таблице");
else
{
    for (int i = 0; i < massivVivodov.Length; i++)
    {
        Console.WriteLine(massivVivodov[i]);
    }
}


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double [,] matrica3 = (RazmerTablici());
double [] sum = new double[matrica3.GetLength(1)];
for (int i = 0; i < matrica3.GetLength(0); i++)
{
    for (int j = 0; j < matrica3.GetLength(1); j++)
    {
        matrica3[i,j] = new Random().Next(10 , 100); 
        sum[j] = sum[j] + matrica3[i,j];
        Console.Write(matrica3[i,j] + " ");
    }
Console.WriteLine();
}
for (int i = 0; i < sum.Length; i++)
{
    Console.WriteLine($"Среднее арифметическое {i + 1} столбца = " 
                        + Math.Round(sum[i]/matrica3.GetLength(0), 2));
}
