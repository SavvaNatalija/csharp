Console.WriteLine("start");
Console.WriteLine("Введите целое положительное число");
int N = int.Parse(Console.ReadLine());
int i = 2;
while (i <= N)
{
    Console.Write(i + " ");
    i+=2;
}
Console.WriteLine("end");