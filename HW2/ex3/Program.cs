Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b) && (b >= c))
{
    Console.WriteLine($"{a} {b} {c}");
}
else if ((a >= b) && (a >= c) && (b < c))
{
    Console.WriteLine($"{a} {c} {b}");
}
else if ((b > a) && (a >= c))
{
    Console.WriteLine($"{b} {a} {c}");
}
else if ((b > a) && (b >= c) && (c >= a))
{
    Console.WriteLine($"{b} {c} {a}");
}
else if ((c >= a) && (c >= b) && (b >= a))
{
    Console.WriteLine($"{c} {b} {a}");
}
else
{
    Console.WriteLine($"{c} {a} {b}");
}