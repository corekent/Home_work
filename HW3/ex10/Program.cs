Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int reverse;
int b;
do
{
    b = a % 10;
    reverse = b*10;
    a /= 10;

}
while (a != 0);
Console.WriteLine($"Ваше число наоборот:{reverse}");