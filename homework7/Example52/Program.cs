//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

void Average (int[,] matr)
{
    int summa = 0; 
    double average = 0.0;
    int k = matr.GetLength(0);
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summa += matr [i, j];
        }
    average = ((double)summa/(double)k);
    Console.WriteLine($"среднее арифметическое число столбца {j} = {average}");
    average = 0.0;
    }

}

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);

Average(matrix);