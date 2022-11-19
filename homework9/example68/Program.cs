// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int a, int b)
{
    int x = 0;
    if (a == 0) { x = b + 1;}
    if (a > 0)
    {
        if (b == 0) { x = Ackerman(a-1, 1);}
        else
        {
            x = Ackerman(a-1, Ackerman(a, b-1));
        }
    }
    //Console.WriteLine($"Функция Аккермана чисел {a} и {b} равна {x}");
    return x;
}

void Print(int a, int b)
{
    Console.WriteLine($"Функция Аккермана чисел {a} и {b} равна {Ackerman(a,b)}");
}

Print(2,3);
Print(3,2);