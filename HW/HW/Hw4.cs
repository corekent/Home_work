using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Hw4
    {
        public static int[] CreateAnArrayWithRandom(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        public void OutputAnArrayToTheConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void SolveEx1()
        {
            Console.Write("Введите длину массива: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"Минимальный элемент: {GetMinElementInArray(array)}");
        }
        public int GetMinElementInArray(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public void SolveEx2()
        {
            Console.Write("Введите длину массива: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");
            OutputAnArrayToTheConsole(array);
            Console.WriteLine(" ");
            Console.Write($"Максимальный элемент: {GetMaxElementInArray(array)}");
        }

        public int GetMaxElementInArray(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }


    }
}
