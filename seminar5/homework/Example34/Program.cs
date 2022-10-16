// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int a) // рандомный массив с элементами в количестве а
{
    int[] number = new int[a];
    Random elements = new Random();
    for (int i = 0; i < a; i++)
    {
        number[i] = elements.Next(99,1000);
    }
    return number;
}

int Parity(int[] array) // подсчет четных элементов
{
    int j = 0;
    int k = array.Length;
    for (int i = 0; i < k; i++)
    {
        if (array[i] % 2 == 0) 
        {
            j+=1;
        }
    }
    return j;
}

Console.Write("Введите количество элементов в массиве: ");
int a = Int32.Parse(Console.ReadLine());
int[] numbers = RandomArray(a); //задали массив

var str = string.Join(" ", numbers);

Console.WriteLine(str);
Console.WriteLine($"Количество четных элементов в этом массиве равно {Parity(numbers)}");