//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void Multiplication (int[,] matr, int[,] matr1)
{
    int[,] matr2 = new int[matr.GetLength(0),matr1.GetLength(1)];    
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                matr2[i,j] += matr[i,k]*matr1[k,j];                
            }
            Console.Write($"{matr2[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Multiplication(matrix, matrix2);