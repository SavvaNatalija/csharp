void Verification(int a)
{
    if ((a>0)&(a<6))
    {
        Console.WriteLine($"{a} - это рабочий день");
    }
    else if ((a==6)|(a==7))
    {
        Console.WriteLine($"{a} - это выходной день");
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число");
    }
}

Console.WriteLine("Введите цифру дня недели: ");
int x = int.Parse(Console.ReadLine());
Verification(x);