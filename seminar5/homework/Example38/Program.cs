// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] RandomArray(int a) // рандомный массив с элементами в количестве а
{
    double[] number = new double[a];
    Random elements = new Random();
    for (int i = 0; i < a; i++)
    {
        number[i] = elements.NextDouble()*1000;
    }
    return number;
}

double Min(double[] array) // Поиск минимального элемента
{
    double min = array[0];
    int k = array.Length;
    for (int i = 0; i < k; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double Max(double[] array) // Поиск максимального элемента
{
    double max = array[0];
    int k = array.Length;
    for (int i = 0; i < k; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


Console.Write("Введите количество элементов в массиве: ");
int a = Int32.Parse(Console.ReadLine());
double[] numbers = RandomArray(a); //задали массив

var str = string.Join(" ", numbers);

Console.WriteLine(str);
//Console.WriteLine($"Минимальный элемент в массиве равен {Min(numbers)}");
//Console.WriteLine($"Максимальный элемент в массиве равен {Max(numbers)}");
Console.WriteLine($"Разница между максимальным({Max(numbers)}) и минимальным({Min(numbers)}) элементами равна {Max(numbers)-Min(numbers)}");