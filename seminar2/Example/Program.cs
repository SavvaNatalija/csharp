
int n = 12321;
int value = n;

int result = 0;
while (value != 0)
{
    int o = value % 10;
    result = result * 10 + o;
    value = value / 10;
}
System.Console.WriteLine(result == n);