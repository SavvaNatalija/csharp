// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Array(int a) // Пользователь вводит массив с элементами в количестве а
{
    int[] number = new int[a];
    //Random elements = new Random();
    for (int i = 0; i < a; i++)
    {
        Console.Write("Введите число ");
        number[i] = Int32.Parse(Console.ReadLine());
    }
    return number;
}

int Positive(int[] array) // Подсчет положительных чисел
{
    int count = 0;
    int k = array.Length;
    for (int i = 0; i < k; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Write("Введите количество элементов в массиве: ");
int a = Int32.Parse(Console.ReadLine());
int[] numbers = Array(a); //задали массив

var str = string.Join(" ", numbers);

Console.WriteLine(str);
Console.WriteLine($"Количество положительных чисел в данном массиве составляет {Positive(numbers)}");
