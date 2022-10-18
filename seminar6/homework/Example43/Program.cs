// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1x-k2x=b2-b1  x=(b2-b1)/(k1-k2)

 void IntersectionPoint(int a1, int b1, int a2, int b2)
 {
     double x = (double)(b2 - b1)/(a1 - a2);
     double y = a1 * x + b1;
     Console.Write($"точкой пересечения для прямых y = {a1} * x + {b1} и y = {a2} * x + {b2} является точка с координатами  x = {x}, y = {y}"); 
     //return x;
 }

Console.WriteLine("Введите k1 для прямой y = k1 * x + b1");
int k1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите b1 для прямой y = k1 * x + b1");
int b1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 для прямой y = k1 * x + b1");
int k2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 для прямой y = k1 * x + b1");
int b2 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"{k1}, {b1}, {k2}, {b2}");
IntersectionPoint(k1, b1, k2, b2);