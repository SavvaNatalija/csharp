
int SecondDigit (int a)
{
    int result = (a / 10) % 10;
    return result;
}

int n = 12321;
int value = n;

Console.WriteLine("Введите трехзначное целое число: ");

int x = int.Parse(Console.ReadLine());

int b = SecondDigit(x);

Console.WriteLine("Вторая цифра данного числа = " + b);