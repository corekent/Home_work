Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = a; i != 1; i--)
{
    int tmp = i;
    int sumEven = 0;
    int sumOdd = 0;

    if (i % 10 > 9)
    {
        do
        {
            tmp /= 10;
        }
        while (tmp > 9);
    }

    if (tmp % 2 == 0)
    {
        sumEven += tmp;
    }
    else
    {
        sumOdd += tmp;
    }

    if (sumEven > sumOdd)
    {
        Console.WriteLine(i);
    }
}