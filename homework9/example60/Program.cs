// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray (int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }        
    }
}

void Fill (int[,,] matr)
{
    int [] array = new int[matr.GetLength(0)*matr.GetLength(1)*matr.GetLength(2)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10,100);
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10,100);
                    j=0;
                }
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          for (int k = 0; k < matr.GetLength(2); k++)
          {
            matr[i,j,k] = array[count];
            count++;
          }
        }
    }        
}           

int[,,] matrix = new int[2, 2, 2];

Fill(matrix);
PrintArray(matrix);