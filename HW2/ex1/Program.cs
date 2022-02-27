Console.WriteLine("Введите А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B");
int b = Convert.ToInt32(Console.ReadLine());

int c;

if (a == b)
{
    c = a * b;
}
else if (a < b)
{
    c = a - b;
}
else
{
    c = a + b;
}

Console.WriteLine(c);