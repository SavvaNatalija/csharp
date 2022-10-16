//Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

double Sum(int x)
{
    int summa = 0;
    int i = x;
    while (i > 1)
    {
        summa = summa + i % 10;
        i = i / 10;
    }
    return summa;
}


Console.WriteLine("введите целое число: ");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр данного числа составляет {Sum(a)}");