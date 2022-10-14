
int FlipNumber (int v)
{
    int r = v / 10;
    int a = v % 10;
    while (r > 0)    
    {
        a = a * 10  + r % 10; 
        r = r / 10;
    }
    return a;
}



int t = -1;
bool flag = false;

while (!flag)
{
    Console.Write("Введите число ");
    string data = Console.ReadLine();
    flag = int.TryParse(data, out t);
}

int z = FlipNumber(t);
if (t == z)
{
    Console.WriteLine($"число {t} - палиндром");
}
else
{
    Console.WriteLine($"число {t} - не является палиндромом");
}