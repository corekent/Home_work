Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

for (int square = 1; square < Math.Sqrt(a); square++)
{
    b++;
}
Console.WriteLine(b);