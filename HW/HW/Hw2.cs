using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Hw2
    {
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void SolveEx1()
        {
            int a = EnteringNumber("Введите значение А: ");
            int b = EnteringNumber("Введите значение Б: ");
            Console.WriteLine(CompareAndCount(a, b));

        }
        public int CompareAndCount(int a, int b)
        {
            if (a>b)
            {
                return a + b;
            }
            else if(a==b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public void SolveEx2()
        {
            int x = EnteringNumber("Введите Х: ");
            int y = EnteringNumber("Введите У: ");
            Console.WriteLine($"Четверть {DetermineWhichQuarterAPointBelongsTo(x, y)}");
        }
        public int DetermineWhichQuarterAPointBelongsTo(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                throw new Exception("Точка лежит на оси");
            }
            else if((x >= 0) && (y >= 0))
            {
                return 1;
            }
            else if ((x < 0) && (y >= 0))
            {
                return 2;
            }
            else if ((x < 0) && (y < 0))
            {
                return 3;
            }
            else 
            {
                return 4;
            }
        }

        public void SolveEx3()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            int c = EnteringNumber("Введите число 3: ");
            int[] answers = ArangeValuesInAscendingOrder(a, b, c);
            for (int i = 0; i < answers.Length; i++)
            {
                Console.Write(answers[i] + " ");
            }
        }

        public int[] ArangeValuesInAscendingOrder(int a, int b, int c)
        {
            if ((a >= b) && (b >= c))
            {
                int[] arr = { c, b, a };
                return arr;
            }
            else if ((a >= b) && (a >= c) && (b < c))
            {
                int[] arr = { b, c, a };
                return arr;
            }
            else if ((b > a) && (a >= c))
            {
                int[] arr = { c, a, b };
                return arr;
            }
            else if ((b > a) && (b >= c) && (c >= a))
            {
                int[] arr = { a, c, b };
                return arr;
            }
            else if ((c >= a) && (c >= b) && (b >= a))
            {
                int[] arr = { a, b, c };
                return arr;
            }
            else
            {
                int[] arr = { b, a, c};
                return arr;
            }
        }

        //ex4
        public void SolvingTheQuadraticEquation()
        {
            int a = EnteringNumber("Введите A: ");
            int b = EnteringNumber("Введите B: ");
            int c = EnteringNumber("Введите C: ");
            double discriminant = FindTheDiscriminant(a, b, c);
            Console.WriteLine(FindingTheRootsOfAQuadraticEquation(a, b, discriminant));

        }
        public int FindTheDiscriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }
        public string FindingTheRootsOfAQuadraticEquation(int a, int b, double d)
        {
            if (d < 0)
            {
                return "Действительных коней нет";
            }
            else if (d == 0)
            {
                return $"x = {(-b) / (2 * a)}";
            }
            else
            {
                return $"x1 = {(-b - Math.Sqrt(d)) / (2 * a)}; x2 = {(-b + Math.Sqrt(d)) / (2 * a)}";
            }
        }

        public void SolveEx5()
        {
            int a = EnteringNumber("Введите число от 10 до 99: ");
            Console.WriteLine(ConvertANumberToAString(a));
        }
        public string ConvertANumberToAString(int a)
        {
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
                return $"Результат: {figure1}-{figure2}";
            }
            else
            {
                return $"Результат: {figure1}";
            }
        }
    }
}
