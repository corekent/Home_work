Console.Write("enter a number:");

int a = Convert.ToInt32(Console.ReadLine());
int wholePart = a / 10;
int remains = a % 10;
string figure1;
string figure2;

if (wholePart == 1 && remains < 3)
{
    figure1 = a switch
    {
        10 => "ten",
        11 => "eleven",
        _ => "twelve",
    };
}
else if (wholePart == 1 && remains > 2)
{
    figure1 = remains switch
    {
        3 => "firteen",
        4 => "fourteen",
        5 => "fifteen",
        6 => "sixteen",
        7 => "seventeen",
        8 => "eighteen",
        9 => "nineteen",
        _ => "-",
    };
}
else if (wholePart != 1)
{
    figure1 = wholePart switch
    {
        2 => "twenty",
        3 => "fhirty",
        4 => "forty",
        5 => "fifty",
        6 => "sixty",
        7 => "seventy",
        8 => "eighty",
        9 => "ninety",
        _ => "-",
    };
}
else
{
    figure1 = "-";
}


if (remains > 0 && wholePart > 1)
{
    figure2 = remains switch
    {
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eight",
        _ => "nine",
    };
}
else
{
    figure2 = " ";
}

if (wholePart > 1 && remains != 0)
{
    Console.WriteLine($"result: {figure1}-{figure2}");
}
else
{
    Console.WriteLine($"result: {figure1}");
}