Console.WriteLine("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());

for (int divider = 1; divider < 1000; divider++)
{
    int resoult = divider % a;
    if (resoult == 0)
    {
        Console.WriteLine(divider);
    }
}