string Cube(int a)
{
    int i = 1;
    string cube = String.Empty;
    while (i <= a)
    {
        cube = cube + ' ' + i * i * i;
        i++;
    }
    return cube;
}

int t = -1;
bool flag = false;

while (!flag)
{
    Console.Write("Введите число ");
    string data = Console.ReadLine();
    flag = int.TryParse(data, out t);
}

Console.WriteLine(Cube(t));
