Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 1;
int c;

do
{
    c = a + b;
    a = b;
    b = c;
    n -= 1;
}
while (n - 2 != 0);

Console.WriteLine(c);