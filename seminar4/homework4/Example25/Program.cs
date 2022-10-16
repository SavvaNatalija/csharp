double Expent(int x, int y)
{
    double result = Math.Pow(x, y);
    return result;
}

Console.WriteLine("Введите целое число");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine(a + b);
Console.WriteLine($"{a} в степени {b} = {Expent(a, b)}");