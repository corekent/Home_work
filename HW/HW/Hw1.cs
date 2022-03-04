using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Hw1
    {
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public string EnteringString(string message)
        {
            Console.Write(message);
            string value = Console.ReadLine();
            return value;
        }

        //ex1
        public void SolveEx1()
        {
            int numerator = EnteringNumber("Числитель: ");
            int denominator = EnteringNumber("Знаменатель: ");

            Console.WriteLine($"{numerator}/{denominator} = {Division(numerator, denominator)}");
            Console.WriteLine($"Остаток от деления: {CalculateTheRemainderOfDivision(numerator, denominator)}");
        }
        public int Division(int numerator, int denominator)
        {
            return numerator / denominator;
        }
        public int CalculateTheRemainderOfDivision(int numerator, int denominator)
        {
            return numerator % denominator;
        }

        public void SolveEx2()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            double c = Math(a, b);
            Console.WriteLine($"Ответ: {c}");
        }
        public double Math(int a, int b)
        {
            double c = (5.0 * a + b * b) / (b - a);
            return c;
        }
        
        public void SolveEx3()
        {
            string a = EnteringString("Введите значение А: ");
            string b = EnteringString("Введите значение Б: ");
            string newA;
            string newB;
            SwapStrinqValues(a, b, out newA, out newB);
            Console.WriteLine($"Значение А: {newA}");
            Console.WriteLine($"Значение Б: {newB}");
        }
        public void SwapStrinqValues(string a, string b, out string newA, out string newB)
        {
            newA = b;
            newB = a;
        }

        public void SolveEx4()
        {
            Console.WriteLine("AX+B=C");
            Console.WriteLine("Введите число А");
            double a = EnteringNumber("A=");
            Console.WriteLine("Введите число B");
            double b = EnteringNumber("B=");
            Console.WriteLine("Введите число C");
            double c = EnteringNumber("C=");

            Console.WriteLine($"X={SolveTheLinearEquation(a, b, c)}");
        }
        public double SolveTheLinearEquation(double a, double b, double c)
        {
            double x = (c - b) / a * 0.1;
            return x;
        }

        //ex5
        public void DeriveTheEquationOfAStraightLinePassingThroughTwoPoints()
        {
            double y1 = EnteringNumber("Введите у1: ");
            double x1 = EnteringNumber("Введите x1: ");
            double y2 = EnteringNumber("Введите y2: ");
            double x2 = EnteringNumber("Введите x2: ");

            double k = FindTheCoefficientK(y1, x1, y2, x2);
            double b = FindTheCoefficientB(y1, x1, y2, x2, k);
            Console.WriteLine($"Уравнение прямой: y={k}*x+{b}");
        }
        public double FindTheCoefficientK(double y1, double x1, double y2, double x2)
        {
            double k = (y1 - y2) / (x1 - x2);
            return k;
        }
        public double FindTheCoefficientB(double y1, double x1, double y2, double x2, double k)
        {
            double b = y2 - k * x2;
            return b;
        }
    }
}
