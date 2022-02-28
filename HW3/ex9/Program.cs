Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int even = 0;
int odd = 0;

do
{

    if (a % 10 == 0)
    {
        odd += 1;
    }
    else if (a % 2 == 0)
    {
        even += 1;
    }
    else
    {
        odd += 1;
    }
    a /= 10;
}
while (a != 0);
Console.WriteLine($"количество четных цифр: {even}");
Console.WriteLine($"количество нечетных цифр: {odd}");