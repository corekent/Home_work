Console.Write("A = ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("B = ");
double b = Convert.ToInt32(Console.ReadLine());

Console.Write("C = ");
double c = Convert.ToInt32(Console.ReadLine());

double x = (c - b) / a;

Console.WriteLine($"Уравнение: {a}*x+{b}={c}");
Console.WriteLine($"x = {x}");
