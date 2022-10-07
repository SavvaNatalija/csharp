Console.WriteLine("1 вариант");
int x = 4;
string answer = "четное число";
if ((x%2) > 0)
{
    answer = "число нечетное";
}
Console.WriteLine(x + " - " + answer);
Console.WriteLine("2 вариант");
x = -3;
answer = "четное число";
if ((x%2) > 0)
{
    answer = "число нечетное";
}
Console.WriteLine(x + " - " + answer);
Console.WriteLine("3 вариант");
x = 7;
answer = "четное число";
if ((x%2) > 0)
{
    answer = "число нечетное";
}
Console.WriteLine(x + " - " + answer);
Console.WriteLine("4 вариант, введите целое число");
x = int.Parse(Console.ReadLine());
answer = "четное число";
if ((x%2) > 0)
{
    answer = "число нечетное";
}
Console.WriteLine(x + " - " + answer);