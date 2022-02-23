Console.Write("x1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("x2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());

double k = (y1 - y2) / (x1 - x2);
double b = y2 - k * x2;

Console.Write($"Уравнение прямой: y = {k}x + {b}");