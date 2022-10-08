
int ThirdDigit (int a)
{
    int result = ((a / 10) / 10) % 10;
    return result;
}

int n = 12321;
int value = n;

Console.WriteLine("Введите трехзначное целое число: ");

int x = int.Parse(Console.ReadLine());

int b = ThirdDigit(x);

if (b > 0)
{
Console.WriteLine("Третья цифра данного числа = " + b);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}