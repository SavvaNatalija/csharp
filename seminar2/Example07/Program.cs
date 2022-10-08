
string MyMethod(int n)
{
    int m = -n;
    string text = "";
    while (m <= n)
    {
        text = text + $"{m} ";
        m++;
    }
    return text;
}

string result = MyMethod(5);
System.Console.WriteLine(result);
