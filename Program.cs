// Console.WriteLine("Здравствуйте. Найдем из ваших двух чисел большее");
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a<b)
// {
//     Console.WriteLine(b + " максимальное число");
// }
// else
// {
//     if (a==b) { Console.WriteLine("Эти числа равны");}
//     else {Console.WriteLine(a + " максимальное число");};
// };
// Console.WriteLine("Теперь найдем из ваших трех чисел большее");
// Console.Write("Введите первое число: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int a3 = Convert.ToInt32(Console.ReadLine());
// int max = a1;
// if (a2 > max) { max = a2;};
// if (a3 > max) { max = a3;};
// Console.WriteLine("Максимальное число: " + max);
// Console.WriteLine("Теперь мы узнаем, является ли ваше число четным");
// Console.Write("Введите число: ");
// int a4 = Convert.ToInt32(Console.ReadLine());
// if (a4%2 == 0)
// {
//     Console.WriteLine(a4 + " четное");
//  }
//  else
//  {
//     Console.WriteLine(a4 + " нечетное");
//  };
// Console.WriteLine("Ну и в конце мы вычислим все четные числа от 1 до вашего указанного числа");
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while (i <= N)
// {
//     if (i%2 == 0)
//         {
//             Console.Write(i + " ");
//         };
//     i++;
// };
// int fuk(int x1, int x2, int x3)
// {
//     int maxim = x1;
//     if (x2 > maxim)
//     {
//         maxim = x2;
//     }
//     ;
//     if (x3 > maxim)
//     {
//         maxim = x3;
//     }
//     ;
//     return maxim;
// }
// int[] masik = { 4, 6, 8, 6, 7, 0, 9, 3, 6 };
// int Max = fuk(
//     fuk(masik[0], masik[1], masik[2]),
//     fuk(masik[3], masik[4], masik[5]),
//     fuk(masik[6], masik[7], masik[8])
// );
// Console.WriteLine("Максимальное число из массива: " + Max);

// void Massive(int[] naborchik)
// {
//     int dlina = naborchik.Length;
//     int i = 0;
//     while (i < dlina)
//     {
//         naborchik[i] = new Random().Next(5,20);
//         i++;
//     }; 
// }
// void Printik(int[] nabor)
// {
//     int dlin = nabor.Length;
//     int pi = 0;
//     while (pi < dlin)
//     {
//         Console.Write(nabor[pi] + " ");
//         pi++;
//     }
// }
// int [] masik = new int[5];
// Massive(masik);
// Printik(masik);

// вычитание второй цифры из числа. b у нас в этом коде является второй цифрой, тоесть в последней строчке вместо d указываем b
// for (int i = 0; i < 10; i++)
// {
// int x = new Random().Next(100, 1000);
// int a = x / 100;
// int b1 = x % 100;
// int b = b1 / 10;
// int c = b1 % 10;
// int d = a * 10 + c;
// Console.WriteLine(x + " --> " + a + " " + b + " " + c + " --> " + d);
//}

// кратно или не кратно число числу
// for (int i = 0; i < 12; i++)
// {
//     int x = new Random().Next(4, 101);
//     int y = new Random().Next(2, 11);
//     if ( x % y == 0)
//     {
//         Console.WriteLine(y + " кратно " + x);
//     }
//     else
//     {
//         Console.WriteLine(y + " не кратно " + x + " . Остаток от деления: " + x%y);
//     };
// }

// Нахождение третьей цифры в числе
//  for (int i = 0; i < 10; i++)
//  {
//     int x = new Random().Next(1, 10000000000);
//     int a = 1;
//     int x1 = x;
//     int x2 = x;
//     while ( x1 > 9)
//     {
//         a++;
//         x1 = x1 / 10;
//     }
//     while (a > 3)
//     {
//         a--;
//         x2 = x2/10;
//     }
//     if (x > 100)
//     {
//         Console.WriteLine(x + " --> " + (x2%100)%10);
//     }
//     else
//     {
//         Console.WriteLine($"Число {x} меньше трехзначного, поэтому третьей цифры нет");
//     }
// }

Console.Write("Ведите число от 1 до 7, которое указывает номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 6 )
{
    Console.WriteLine("не выходной");
}
else
{
    Console.WriteLine("выходной");
}