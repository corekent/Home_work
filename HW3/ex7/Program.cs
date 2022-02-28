Console.WriteLine("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());

int c;
if (a > b)
{
    if (a % b > 0)
    {
        do
        {
            c = a % b;
            a = b;
            b = c;
        }
        while (c == 0);
    }
    else
    {
        c = b;
    }
    Console.WriteLine(c);
}
else if (a < b)
{

    if (b % a > 0)
    {
        do
        {
            c = b % a;
            b = a;
            a = c;
        }
        while (c == 0);
    }
    else
    {
        c = b;
    }
    Console.WriteLine(c);
}
else if (a == b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("1");
}