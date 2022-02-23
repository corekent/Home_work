Console.Write("А = ");
string a = Console.ReadLine();
Console.Write("B = ");
string b = Console.ReadLine();

string tmp = a;
a = b;
b = tmp;

Console.WriteLine();
Console.WriteLine($"A = {a}");
Console.WriteLine($"B = {b}");
