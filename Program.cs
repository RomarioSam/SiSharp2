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

// Нахождение третьей цифры в числе. Второй цикл можно было заменить Math.Pow(), но тогда переменной х2 нужен тип double(почему-то...)
// Здесь я искал количество цифр, потом находил число из первых трех цифр, а потом уже находил третью цифру
// Скажу чесно, узнал у одногруппника, что можно было и не находить количество цифр, а остановиться, когда число будет меньше 999. 
//  for (int i = 0; i < 5; i++)
//  {
//     int x = new Random().Next(-100000, 100000);
//     int a = 1;
//     int x1 = x;
//     int x2 = x;
//     while ( x1 > 9 | x1 < -9)
//     {
//         a++;
//         x1 = x1 / 10;
//     }
//     while (a > 3)
//     {
//         a--;            
//         x2 = x2/10;
//     }
//     if (x > 100 | x < - 100)
//     {
//         Console.WriteLine(x + " --> " + x2%10);
//     }
//     else
//     {
//         Console.WriteLine($"Число {x} меньше трехзначного, поэтому третьей цифры нет");
//     }
// }

// int x = new Random().Next(-100000, 100000);
// x = -8125451;
// int x1 = x;
// while ( x1 > 999 | x1 < -999)
//     {
//         x1 = x1 / 10;
//     }
// if (x > 100 | x < - 100)
//     {
//         Console.WriteLine(x + " --> " + Math.Abs(x1%10));
//     }
//     else
//     {
//         Console.WriteLine($"Число {x} меньше трехзначного, поэтому третьей цифры нет");
//     }


// Console.Write("Ведите число от 1 до 7, которое указывает номер дня недели: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 6 )
// {
//     Console.WriteLine("не выходной");
// }
// else
// {
//     Console.WriteLine("выходной");
// }

// цикл форыч ин
// string [] masik = new string[3] { "1","2","6"};
// foreach (string i in masik)
// {
//     Console.Write(i + "__\n");
// }

//расстояние между тремя(сначала было с двумя) точками координат
// int x1 = new Random().Next(-100, 100);
// int x2 = new Random().Next(-100, 100);
// int y1 = new Random().Next(-100, 100);
// int y2 = new Random().Next(-100, 100);
// int z1 = new Random().Next(-100, 100);
// int z2 = new Random().Next(-100, 100);
// // x1 =3;
// // x2 = -5;
// // y1 = 1;
// // y2 = -5;
// // z1 = -12;
// // z2 = 12;
// Console.WriteLine(x1 + "    "+ y1 + "    " + z1 + "\n" + x2 + "    "+ y2 + "    " + z2);
// int x3 = x1 -x2;
// int y3 = y1 - y2;
// int z3 = z1 -z2;
// double v = Math.Sqrt(Math.Pow(x3,2) + Math.Pow(y3,2));
// double q = Math.Sqrt(Math.Pow(z3,2) + Math.Pow(v,2));
// Console.WriteLine(Math.Floor(q));

// выводим " таблицу " кубoв из чисел от 1 до N
// Console.Write("ВВедите число (желательно небольшое, до 20) : ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while ( i <= N)
// {
//     Console.Write(Math.Pow(i,3) + "___");
//     i++;
// }

// полиндром через строку!!! С учетом отрицательного числа!!! С независимым количеством цифр!!! Но не сработает со строкой в начале которой стоит "-"
// Console.Write("ВВедите число: ");
// string x = Console.ReadLine();
// string n = "-";
// string x1 = x;
// if (n[0] == x[0])
//     { x1 = x1.Remove(0,1);}
// int l = x1.Length - 1;
// int i = 0;
// while (i < l )
// {
//     if (x1[i] == x1[l])
//     {
//         Console.WriteLine(x1[i] + "__" + x1[l]);
//         i++;
//         l--;
//     }
//     else
//     {
//     Console.WriteLine($"Число {x} не является полиндромом.");
//     break;
//     };
// };
// if (l - i < 2) Console.WriteLine($"Число {x} - полиндром!))"); 

// полиндром для 5-значного числа
// Console.Write("ВВедите пятизначное число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = Math.Abs(x);
// int a1 = x1/10000;
// int a2 = (x1/1000)%10;
// int a3 = (x1/100)%10;
// int a4 = (x1/10)%10;
// int a5 = x1%10;
// Console.WriteLine(a1+ "__"+a2+"__"+a3+"__"+a4+"__"+a5);
// if (a1 == a5 && a2 == a4)
// {
//     Console.WriteLine("Число "+ x + " полиндром!!!!!!УУУУУУРРРААААА");
// }
// else
// {
//     Console.WriteLine("Число "+ x + " не полиндром.");
// }

// сортировка массива без функций
// int [] x = { 1,3,2,4,1,3};
// int i = 0;
// while ( i < x.Length )
// {
//    int a = i;
//    while ( a < x.Length )
//     {
//        if (x[i] > x[a]) {int n = x[i]; x[i] = x[a]; x[a] = n;};
//        a++;
//      };
// Console.Write(x[i]+ "  ");
// i++;
//  };

// возведение в степень одного в другое
// Console.Write("Напишите два числа через пробел. Первое будем возводить в степень, равную второму числу: ");
// string x = Console.ReadLine();
// int[] y = x.Split(" ").Select(Int32.Parse).ToArray();  // ну или в двух строчках мы делаем каждую строку числом. Здесь используется метод Select, который непонятно как работает
// Console.WriteLine(y[0] + " в " + y[1] + " степени = "+ Math.Pow(y[0],y[1]));

                                                   // string [] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                                                   //                             "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};
  // это я разбирался что такое .Select                                                 // var carObj = cars.Select(p => new { LastNa = p, Length = p.Length });
                                                   // foreach (var i in carObj)
                                                   //         Console.WriteLine("Автомобиль {0} имеет длину {1} символов", i.LastNa, i.Length);

// сумма цифр числа
// Console.Write("Введите число: ");
// string x = Console.ReadLine();
// string x1 = x;
// int sum = 0;
// string n ="-";
// if (x[0] == n[0])
//     x = x.Remove(0,1);  
// int [] y = new int[x.Length];
// for (int i = 0; i<y.Length; i++) {
//    y[i] = Convert.ToInt32(x[i].ToString()); // жуть просто. единица становилась 49 потомучто у нас тип char каждого элемента строки. и поэтому мы переделываем .ToString, что бы ASCII перевел все правильно
//    sum = sum + y[i];
//    Console.WriteLine(y[i]+ " " + sum);
//                   };
// Console.WriteLine($"Сумма цифр в числе {x1} равна {sum}");

// делаем из указанного количества чисел массив... пользуясь функциями
// void PrintNashArray(int Length)     // поставил точку с запятой в конце этой строчки. 2 часа коту под хвост. 
// {
//    string massiv = "";
// for (int i = 0; i < Length; i++ )
//    {
//    string x = new Random().Next(10, 100).ToString();        
//    massiv = massiv + x + ", ";
//    };
// Console.WriteLine("[ "+ massiv + "]");
// };
// Console.Write("Введите количество чисел в массиве: ");
// int L = Convert.ToInt32(Console.ReadLine());
// PrintNashArray(L);

int [] funkDlyaZapolneniyaMassiva(string x)   // если мы выводим массив из функции, то перед именем указать надо тип данных и СКОБОЧКИ!
   {     
      int[] y = x.Split(" ").Select(Int32.Parse).ToArray();
      int [] massiv = new int[y[2]];
      Console.Write("Вот ваш массив:  [");
      for(int i = 0 ; i < y[2] ; i++)
      {
      int n = new Random().Next(y[0], y[1]);
      massiv[i] = n; 
      Console.Write( massiv[i] + "__");
      };
      Console.WriteLine("]");
      return massiv;
   };
Console.WriteLine("Укажите через пробел сначала начальное число массива, потом конечное число, а потом длину массива");
int [] mass = funkDlyaZapolneniyaMassiva(Console.ReadLine());

// // теперь уже отдельное задание. Найти количество четных чисел в массиве
// int count = 0;
// for(int i = 0; i < mass.Length; i++)
//    {
//       if ( mass[i]%2 == 0)
//       count++;
//    };
// Console.WriteLine("Количество четных чисел в массиве: " + count);

// находим сумму чисел в массиве, которые стоят на нечетных позициях
// int summa = 0;
// for (int i = 0 ; i < mass.Length; i = i + 2)                     // на нечетных позициях. если с нечетным индексом, то i  меняем на 1
// summa = summa + mass[i];
// Console.WriteLine("Сумма чисел на нечетных позициях равна: " + summa);

// находим разницу между минимальным и максимальным
// int min = mass[0];
// int max = mass[0];
// for (int i = 1; i< mass.Length; i++)
// {
//    if ( mass[i] > max) max = mass[i];
//    if ( mass[i] < min) min = mass[i];
// };
// Console.WriteLine("Разница между максимальным и минимальным равна: " + (max - min));










