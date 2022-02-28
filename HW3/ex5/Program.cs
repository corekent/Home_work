Console.WriteLine("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите В:");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (a < b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

for ( int i = a + 1; i < b; i++)
{
     if (i % 7 == 0)
     {
         sum += i;
     }
}

Console.WriteLine($"Результат: {sum}");

