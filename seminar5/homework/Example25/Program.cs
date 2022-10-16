//Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//переделала эту задачу без math.pow

double Expent(int x, int y)
{
    double result = x;
    for (int i = 1; i < y; i++)
    {
        result *= x;
    }
    return result;
}

Console.WriteLine("Введите целое число");
int a = Int32.Parse(System.Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Int32.Parse(System.Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {Expent(a, b)}");