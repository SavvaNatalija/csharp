Console.WriteLine("1 вариант");
int x = 2, y = 3, z = 7;
int max = x;
if (max < y)
{
    max =y;
}
if (max < z)
{
    max = z;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("2 вариант");
x = 44;
y = 5;
z = 78;
max = x;
if (max < y)
{
    max =y;
}
if (max < z)
{
    max = z;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("3 вариант");
x = 22;
y = 3;
z = 9;
max = x;
if (max < y)
{
    max =y;
}
if (max < z)
{
    max = z;
}
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("end ");
Console.WriteLine("4 вариант");
Console.WriteLine("Введите первое целое число: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
z = int.Parse(Console.ReadLine());
max = x;
if (max < y)
{
    max =y;
}
if (max < z)
{
    max = z;
}
Console.WriteLine("Максимальное число " + max);