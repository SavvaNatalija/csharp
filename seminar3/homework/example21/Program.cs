double distance (int a1, int a2, int a3, int b1, int b2, int b3)
{
    double d = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((b2 - a2), 2) + Math.Pow((b3 - a3), 2));
    return Math.Round(d, 2);
}


Console.WriteLine("Введите x-координату точки");
int x1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите y-координату точки");
int y1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите z-координату точки");
int z1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите x-координату точки");
int x2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите y-координату точки");
int y2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите z-координату точки");
int z2 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между этими точками равно {distance(x1, y1, z1, x2, y2, z2)}");
