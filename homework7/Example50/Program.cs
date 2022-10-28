//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,20); //[1,20)
        }
    }
}

void Search (int[,] matr, int a)
{
    int k = 0;
    int l = 0;
    string search = "такого элемента нет";
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == a)
            {
                k = i;
                l = j;
                search = $"число находится на позиции [{k}, {l}]";
                Console.WriteLine(search);
            }
        }
    }
    if (search == "такого элемента нет")
    {
        Console.WriteLine(search);
    }
}

int[,] matrix = new int[7, 8];
//PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
Console.Write("Введите число, которое необходимо найти ");
int x = Int32.Parse(Console.ReadLine());

Search(matrix, x);