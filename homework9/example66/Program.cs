// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Sum(int a, int b)
{
    if (a > b) 
    {
        int x = a;
        a = b;
        b = x;
    } 
    int sum = 0;
    for (int i = a; i <= b; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма чисел от {a} до {b} составляет {sum}");
}

int InputNumber()
{
    //int x = 0;
    Console.Write("Введите число: ");
    int x = Int32.Parse(Console.ReadLine());
    return x;
}

int n = InputNumber();
int m = InputNumber();

Sum(n, m);