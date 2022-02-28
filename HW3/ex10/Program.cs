Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string reverse = " ";
int b;
do
{
    b = a % 10;
    string number = Convert.ToString(b);
    reverse += number;
    a /= 10;

}
while (a != 0);
Console.WriteLine($"Ваше число наоборот:{reverse}");