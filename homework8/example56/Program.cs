//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
            matr[i, j] = new Random().Next(1,10); //[1,10)
        }
    }
}

void SearchMinLine (int[,] matr)
{
    int[] matr2 = new int[matr.GetLength(0)];    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr2[i] = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr2[i] += matr[i,j];
        }
    }
    int min = matr2[0];
    int number = 0; 
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        if (min > matr2[i]) 
        {
            min = matr2[i];
            number = i;
        }
    }
    Console.WriteLine($"Номер строки, с наименьшей суммой элементов ({min}) - {number}");
}

int[,] matrix = new int[4, 4];


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

SearchMinLine(matrix);