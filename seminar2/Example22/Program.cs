//Найти расстояние между точками в пространстве 2D/3D

//1. откуда значения
//2. вычисление
//3. печать результата

double GetValue(string text)
{
    System.Console.WriteLine(text + ": ");
    double value = System.Convert.ToDouble(System.Console.ReadLine());
    return value;
}

void Print(double x1, double y1, double x2, double y2, double res)
{
    // |A(1, 2) B(4, 5)| = 6;
    // string output = "|A(" + ax + ", " + ay + "); B(" +
    //                         bx + ", " + by + ")| = " + result; 
    double r = System.Math.Round(res,2); //округление до 2 чисел
    string output = $"|A({x1}, {y1}); B({x2}, {y2})| = {r}";
    System.Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by)
{
    // double x = (ax - bx)*(ax - bx);
    // double y = Math.Pow(ay - by,2);
    // double result = Math.Sqrt(y + x);
    // return result;
    double result = System.Math.Sqrt(System.Math.Pow(ay - by,2) + System.Math.Pow(ax - bx,2));
    return result;
}


double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDistance(ax, ay, bx, by);
Print(ax, ay, bx, by, dis);