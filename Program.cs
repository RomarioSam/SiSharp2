Console.WriteLine("Здравствуйте. Найдем из ваших двух чисел большее");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
{ 
    Console.WriteLine(b + " максимальное число");
}
else
{
    if (a==b) { Console.WriteLine("Эти числа равны");} 
    else {Console.WriteLine(a + " максимальное число");};
};
Console.WriteLine("Теперь найдем из ваших трех чисел большее");
Console.Write("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int a3 = Convert.ToInt32(Console.ReadLine());
int max = a1;
if (a2 > max) { max = a2;};
if (a3 > max) { max = a3;};
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Теперь мы узнаем, является ли ваше число четным");
Console.Write("Введите число: ");
int a4 = Convert.ToInt32(Console.ReadLine());
if (a4%2 == 0) 
{
    Console.WriteLine(a4 + " четное");
 }
 else
 {
    Console.WriteLine(a4 + " нечетное");
 };
Console.WriteLine("Ну и в конце мы вычислим все четные числа от 1 до вашего указанного числа");
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    if (i%2 == 0)
        {
            Console.Write(i + " ");
        };
    i++;
};