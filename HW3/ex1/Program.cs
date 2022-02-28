Console.Write("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите В: ");
int b = Convert.ToInt32(Console.ReadLine());

int tmp = 1;

for (int i = 1; i <= b; i++)
{
    tmp = tmp * a;
}

Console.WriteLine($"A^B = {tmp}");
