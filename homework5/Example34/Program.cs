// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] RandomArray(int a)
{
    int[] numbers = new int[a];
    for (int i = 0; i < a; i++)
    {
        numbers[i] = Random.Next(99,1000);
    }
    return numbers[a];
}

Console.Write("Введите количество элементов в массиве: ");
int a = Int32.Parse(Console.Readline());
//int[] numbers = new int[a];

Console.WriteLine($"{string.Join(", ", RandomArray(numbers[a]))}");