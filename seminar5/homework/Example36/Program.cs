// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int a) // рандомный массив с элементами в количестве а
{
    int[] number = new int[a];
    Random elements = new Random();
    for (int i = 0; i < a; i++)
    {
        number[i] = elements.Next(-10000,10000);
    }
    return number;
}

int Parity(int[] array) // подсчет суммы нечетных элементов
{
    int j = 0;
    int k = array.Length;
    int i = 1;
    while (i < k)
    {
        j = j + array[i];
        i += 2;
        Console.WriteLine(j);
    }
    return j;
}

Console.Write("Введите количество элементов в массиве: ");
int a = Int32.Parse(Console.ReadLine());
int[] numbers = RandomArray(a); //задали массив

var str = string.Join(" ", numbers);

Console.WriteLine(str);
Console.WriteLine($"Сумма нечетных элементов в этом массиве равна {Parity(numbers)}");