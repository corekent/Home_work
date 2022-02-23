Console.Write("А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());
double answer = (5.0 * a + b * b) / (b - a);
Console.WriteLine($"(5 * {a} + {b}^2)/({b}-{a}) = {answer}");