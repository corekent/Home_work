using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Hw3
    {
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void SolveEx1()
        {
            int a = EnteringNumber("Введите А: ");
            int b = EnteringNumber("Введите В: ");
            Console.WriteLine(CalculateANumberToAPover(a, b));
        }
        public int CalculateANumberToAPover(int a, int b)
        {
            int answer = 1;

            for (int i = 1; i <= b; i++)
            {
                answer = answer * a;
            }
            return answer;
        }

        public void SolveEx2()
        {
            int a = EnteringNumber("Введите А: ");

            if (a<=0)
            {
                Console.WriteLine(0); ;
            }
            else
            {
                int[] answers = SearchForDivisors(a);

                for (int i = 0; i < answers.Length; i++)
                {
                    Console.Write(answers[i] + " ");
                }
            }   
        }

        public int[] SearchForDivisors(int a)
        {
            int[] array = new int[0];
            int count = 0;

            for (int divider = 1; divider < 1000; divider++)
            {
                int resoult = divider % a;
                if (resoult == 0)
                {
                    count++;
                    Array.Resize(ref array, count);
                    array[count - 1] = divider;
                }
            }

            return array;
        }

        public void SolveEx3()
        {
            int a = EnteringNumber("Введите А: ");
            Console.WriteLine($"Колличество элементов, квадрат которых меньше чем А: {FindCountOfElemrntsWhoseSquareIsLessThanA(a)}");
        }

        public int FindCountOfElemrntsWhoseSquareIsLessThanA(int a)
        {
            int b = 0;
            for (int square = 1; square < Math.Sqrt(a); square++)
            {
                b++;
            }
            return b;
        }

        public void SolveEx4()
        {
            int a = EnteringNumber("Введите А: ");
            Console.WriteLine(FindLargestDivisor(a));
        }
        public int FindLargestDivisor(int a)
        {
            int divisor = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    divisor = i;
                }
            }
            return divisor;
        }

        public void SolveEx5()
        {
            int a = EnteringNumber("Введите А: ");
            int b = EnteringNumber("Введите B: ");
            Console.WriteLine($"Результат: {FindTheSumOfElementsThatAreDivisibleBySeven(a, b)}");
        }
        public int FindTheSumOfElementsThatAreDivisibleBySeven(int a, int b)
        {
            if (b > a)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            int sum = 0;

            if (a > b)
            {
                for (int i = b + 1; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public void SolveEx6()
        {
            int n = EnteringNumber("Введите N: ");
            if (n<0)
            {
                throw new Exception("n must be >0");
            }
            else
            {
                Console.WriteLine($"Результат: {FindNumberOfTheFibonacciSeriesByNumber(n)}");
            }            
        }
        public int FindNumberOfTheFibonacciSeriesByNumber(int n)
        {
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
            return c;
        }

        public void SolveEx7()
        {
            int a = EnteringNumber("Введите A: ");
            int b = EnteringNumber("Введите B: ");
            Console.WriteLine($"Наибольший общий делитель: {FindGreatestCommonDivisor(a, b)}");
        }
        public int FindGreatestCommonDivisor(int a, int b)
        {            
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            if (a != b)
            {
                if (a % b > 0)
                {
                    do
                    {
                        a = b;
                        b = a % b;
                    }
                    while (a % b == 0);
                    return b;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                return a;
            }
        }

        public void SolveEx8()
        {
            int n = EnteringNumber("Введите целое положительное число, которое является кубом целого числа: ");
            Console.WriteLine($"{n} является кубом числа {FindTheRoofOfANamberUsingTheHaifDivisionMetod(n)}");
        }
        public double FindTheRoofOfANamberUsingTheHaifDivisionMetod(int n)
        {
            int diapazonPight = n;
            int diapazonLeft = 0;
            int value = n;

            while (value * value * value != n)
            {
                if (value * value * value > n)
                {
                    diapazonPight = value;
                    value = value / 2;
                }
                else
                {
                    diapazonLeft = value;
                    value = (diapazonLeft + diapazonPight) / 2;
                }
            }
            return value;
        }

        public void SolveEx9()
        {
            int a = EnteringNumber("Введите число: ");
            Console.WriteLine($"количество четных цифр: {FindCountEvenElementsOfANumber(a)}");
            Console.WriteLine($"количество нечетных цифр: {FindCountOddElementsOfANumber(a)}");
        }
        public int FindCountEvenElementsOfANumber(int a)
        {
            int evens = 0;

            do
            {
                if (a % 2 == 0)
                {
                    evens += 1;
                }
                a /= 10;
            }
            while (a != 0);
            return evens;
        }
        public int FindCountOddElementsOfANumber(int a)
        {
            int odds = 0;

            do
            {
                if (a % 2 != 0)
                {
                    odds += 1;
                }
                a /= 10;
            }
            while (a != 0);
            return odds;
        }

        public void SolveEx10()
        {
            int a = EnteringNumber("Введите число: ");
            Console.WriteLine($"Ваше число наоборот:{MirrorTheNumber(a)}");
        }
        public int MirrorTheNumber(int a)
        {
            int reverse = 0;
            do
            {
                reverse = reverse * 10 + a % 10;
                a /= 10;
            }
            while (a != 0);
            return reverse;
        }

        public void SolveEx11()
        {
            int a = EnteringNumber("Введите число: ");

            if (a<=0)
            {
                throw new Exception("a must be >0");
            }
            else
            {
                int[] array = SearchForNumbersWhoseSumOfEvenDigitsIsGreaterThanTheSumOfOddDigits(a);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }            
        }

        public int[] SearchForNumbersWhoseSumOfEvenDigitsIsGreaterThanTheSumOfOddDigits(int a)
        {
            int count = 0;
            
            for (int i = 1; i != a; i++)
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
                    count++;                    
                }
            }

            int[] arr = new int[count];

            for (int i = 1; i != a; i++)
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
                    arr[i-1] = i;
                }
            }
            return arr;
        }

        public void SolveEx12()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            Console.WriteLine($"Ответ: {SearchForIdenticalDigitsInTwoNumbers(a, b)}");
        }
        public string SearchForIdenticalDigitsInTwoNumbers(int a, int b)
        {
            int x = a;

            while (b != 0)
            {
                while (a != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        return "Да";
                    }
                    a /= 10;
                }
                b /= 10;
                a = x;
            }
            return "Нет";
        }
    }
}

