Console.WriteLine("Введите целое положительное число, которое является кубом целого числа");
double n = Convert.ToDouble(Console.ReadLine());

double a = n;
double c;
double b;

if (n >= 0)
{
    do
    {
        b = a / 2;
        c = b * b * b;
        a = b;
    }
    while (n != c);
    Console.WriteLine($"{n} является кубом числа {b}");
}
else
{
    Console.WriteLine("такого куба нет :(");
}