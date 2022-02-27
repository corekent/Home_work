Console.WriteLine("Введите A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите C:");
int c = Convert.ToInt32(Console.ReadLine());

double d = -b + (4.0 * a * c);



if (d < 0)
{
    Console.WriteLine("Действительных корней нет");
}
else if (d == 0)
{
    Console.WriteLine($"x = {(-b) / (2 * a)}");
}
else
{
    Console.WriteLine($"x1 = {(-b) * Math.Sqrt(d) / (2 * a)}");
    Console.WriteLine($"x2 = {(-b) * -Math.Sqrt(d) / (2 * a)}");
}