// ДЗ к 6 семинару

// Console.Write("Введите через пробел несколько целых чисел: ");
// string x = Console.ReadLine();
// int[] y = x.Split(" ").Select(Int32.Parse).ToArray();
// int count = 0;
// foreach (int i in y)
//     if (i > 0)
//         count++;
// Console.WriteLine("Количество положительных чисел в вашем вводе = " + count);

Console.Write("Введите через пробел b1 k1 b2 k2 : ");
string mass = Console.ReadLine();
int[] intmass = mass.Split(" ").Select(Int32.Parse).ToArray();
double x = (double)(intmass[2] - intmass[0])/(intmass[1] - intmass[3]);  // канешн особенность такого синтаксиса с типом данных зашквар
Console.WriteLine(x);
double y = intmass[1] * x + intmass[0];
Console.WriteLine($"Точка пересечения прямых y = {intmass[1]}*x + {intmass[0]} и y = " +
                  $"{intmass[3]}*x + {intmass[2]} равна: \n {x} по Х оси \n {y} по Y оси");


                  