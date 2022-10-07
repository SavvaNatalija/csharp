Console.WriteLine("1 вариант");
int x = 5, y = 7;
int max = x;
if (max < y)
{
    max =y;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("2 вариант");
x = 2;
y = 10;
max = x;
if (max < y)
{
    max =y;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("3 вариант");
x = -9;
y = -3;
max = x;
if (max < y)
{
    max =y;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("4 вариант");
Console.WriteLine("Введите первое целое число: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
y = int.Parse(Console.ReadLine());
max = x;
if (max < y)
{
    max =y;
}
Console.WriteLine("Максимальное число " + max);