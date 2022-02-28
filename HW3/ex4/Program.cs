Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int devidor = 0;

for (int i = 1; i < a; i++)
{
    if (a % i == 0)
    {
        devidor = i;
    }
}
Console.WriteLine(devidor);
