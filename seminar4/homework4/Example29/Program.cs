//Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void Array(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Int32.Parse(Console.ReadLine());
    }
    Console.WriteLine($"{string.Join(", ", array)} -> [{string.Join(", ", array)}]");
}



Console.WriteLine("Введите количество элементов массива: ");
int a = Int32.Parse(Console.ReadLine());

Array(a);
