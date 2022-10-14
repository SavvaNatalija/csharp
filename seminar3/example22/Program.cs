// 5 ->1, 4, 9, 16, 25

int n = 5;

GetSquare1(n);

void GetSquare1(int n)
{
    int i = 1;
    while (i <= n)
    {
        System.Console.Write((i * i) + " ");
        i++;
    }
}

int[] GetSquare2(int n)
{
    int i =0;
    int[] squares = new int[n];
    while (i<n)
    {
        squares[i] = ((i + 1) * (i + 1));
        i++;
    }
    return squares;
}

System.Console.WriteLine(String.Join(' ', GetSquare2(n)));

//Console.WriteLine(GetSquare2(n));

string GetSquare3(int n)
{
    int i = 1;
    string res = String.Empty;
    while (i<=n)
    {
        res += $"{Convert.ToString(i * i) } ";
        //res = Convert.ToString(i * i) + ' ' + res;
        i++;
    }
    return res;
}

System.Console.WriteLine(GetSquare3(6));

int v;
string data = "132";

bool flag = int.TryParse(data, out v); //проверка значение, численное ли?
if (flag)
{
    System.Console.WriteLine(v);    
}
else
{
    System.Console.WriteLine("Данные кривые");
}

int t = -1;
// добавим условие от 11 до 99
flag = false;

while (!(flag && t > 10 && t < 100))
{
    Console.Write("Введите число ");
    string dat = Console.ReadLine();
    flag = int.TryParse(dat, out t);
}

System.Console.WriteLine(t);