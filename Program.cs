//ДЗ к 8 семинару

int[,] Sozdanie()
{
    Console.Write("Введите количество строк матрицы: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
            if (matrix[i,j] < 10) Console.Write(" " + matrix[i,j] + " ");
            else Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = Sozdanie();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int n = j; n < matrix.GetLength(1); n++)
        {
          int a;
            if (matrix[i,j] < matrix[i,n])
            {
                a = matrix[i,j];
                matrix[i,j] = matrix[i,n];
                matrix[i,n] = a;
            }  
        }
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,] matrix2 = Sozdanie();
int itogsum = 10000;
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        sum = matrix2[i,j] + sum;
    }
    Console.WriteLine(sum);
    if (itogsum > sum)
    itogsum = sum;
}
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        sum = matrix2[i,j] + sum;
    }
    if (itogsum == sum)
    Console.WriteLine((i + 1) + " строка");
}


//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Создаем первую матрицу");
int[,] matrix3 = Sozdanie();
Console.WriteLine("Создаем вторую матрицу");
int[,] matrix4 = Sozdanie();
while (matrix3.GetLength(1) != matrix4.GetLength(0))
{
    Console.WriteLine("Создайте вторую матрицу, чтобы количество столбцов первой матрицы \n" +
                         "было равным количеству строк второй матрицы !");
    Console.WriteLine("Создаем вторую матрицу");
    matrix4 = Sozdanie();
}
Console.WriteLine("Произведение матриц: ");

int[,] matrixProiz = new int[matrix3.GetLength(0), matrix4.GetLength(1)];
for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int n = 0; n < matrix4.GetLength(1); n++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrixProiz[i,n] = matrixProiz[i,n] + matrix3[i,j]*matrix4[j,n];
        }
        if (matrixProiz[i,n] < 10) Console.Write("  " + matrixProiz[i,n] + " ");
        else if (matrixProiz[i,n] < 100) Console.Write(" " + matrixProiz[i,n] + " ");
        else Console.Write(matrixProiz[i,n] + " ");
    }
    Console.WriteLine();
}

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] perm = Enumerable.Range(10, 90).ToArray();
for (int i = 89; i >= 1; i--)
{
   int j = new Random().Next(i + 1);
   int temp = perm[j];                          // генерация рандомных неповторяющихся чисел от 10 до 100
   perm[j] = perm[i];
   perm[i] = temp;
}

Console.Write("Введите длину строки матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] matrix5 = new int[c, b, a];
int m = 0;

for (int i = 0; i < matrix5.GetLength(0); i++)
{
    for (int j = 0; j < matrix5.GetLength(1); j++)
    {
        for (int n = 0; n < matrix5.GetLength(2); n++)
        {
            matrix5[i,j,n] = perm[m];
            m++;
            Console.Write(matrix5[i,j,n] + "(" + i + "," + j + "," + n + ") ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix6 = new int[7,8];
int z = 1;
int i = 0;
int j = 0;
int n = 0;
int a = 1;
int f = 0;
while ( z <= matrix6.GetLength(0) * matrix6.GetLength(1))
{
    f = 0;
    if (matrix6.GetLength(0) * matrix6.GetLength(1) - z <= 0) a = -1;
    while (f < matrix6.GetLength(1) - n - a )
    {
        if (matrix6.GetLength(0) * matrix6.GetLength(1) - z < 0) break;
        matrix6[i,j] = z;
        // Console.Write($"{matrix6[i,j]} ,1 цикл, f = {f}, n = {n}, a = {a}");
        // string br = Console.ReadLine();
        z++;
        j++;
        f++;
    }
    a = 0;
    if (matrix6.GetLength(0) * matrix6.GetLength(1) - z <= 0) a = -1;                    // я уже сам не понимаю, что здесь происходит
    n++;
    f = 0;
    while (f < matrix6.GetLength(0) - n + a)
    {
        if (matrix6.GetLength(0) * matrix6.GetLength(1) - z < 0) break;
        matrix6[i,j] = z;
        // Console.Write($"{matrix6[i,j]} ,2 цикл, f = {f}, n = {n}, a = {a}");
        // string br = Console.ReadLine();
        z++;
        i++;
        f++;
    }
    a = 0;
    if (matrix6.GetLength(0) * matrix6.GetLength(1) - z <= 0) a = 1; 
    f = matrix6.GetLength(1) - n;
    while (f >= 1 - a)
    {
        if (matrix6.GetLength(0) * matrix6.GetLength(1) - z < 0) break;
        matrix6[i,j] = z;
        // Console.Write($"{matrix6[i,j]} ,3 цикл, f = {f}, n = {n}, a = {a}");
        // string br = Console.ReadLine();
        z++;
        j--;
        f--;
    }
    a = 0;
    f = matrix6.GetLength(0) - n;
    if (matrix6.GetLength(0) * matrix6.GetLength(1) - z <= 0) a = 2;
    n++;
    while (f > 1 + a)
    {
        if (matrix6.GetLength(0) * matrix6.GetLength(1) - z < 0) break;
        matrix6[i,j] = z;
        // Console.Write($"{matrix6[i,j]} ,4 цикл, f = {f}, n = {n} , a = {a}");
        // string br = Console.ReadLine();
        z++;
        i--;
        f--;
    }
    a = 0;
}
for (int x = 0; x < matrix6.GetLength(0); x++)
{
    for (int y = 0; y < matrix6.GetLength(1); y++)
    {
        if (matrix6[x,y] < 10) Console.Write(" " + matrix6[x,y] + " ");
        else  Console.Write(matrix6[x,y] + " ");
    }
    Console.WriteLine();
}

