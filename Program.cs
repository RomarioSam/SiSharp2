Console.Write("Введите через пробел несколько целых чисел: ");
int [] x = Convert.ToInt32(Console.ReadLine().Split(" ").ToArray);
Console.WriteLine(x[1]);