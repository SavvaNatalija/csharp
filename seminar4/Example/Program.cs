void UI(string arg)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($">>> {arg} <<<");
    Console.ForegroundColor = color;
}

int Sum1(int a, int b)
{
    return a + b;
}

int Mult(int a, int b)
{
    return a * b;
}

// void Mult2(int a, int b)
// {
//     ConsoleColor color = Console.ForegroundColor;
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine($">>> {arg} <<<");
//     Console.ForegroundColor = color;
// }

// void Sum2(int a, int b)
// {
//     ConsoleColor color = Console.ForegroundColor;
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($">>> {a + b} <<<");
//     Console.ForegroundColor = color;
// }

UI(Sum1(1,2).ToString());
UI(Mult(1,2).ToString());
File.WriteAllText("file.db", Sum1(1,2).ToString());

