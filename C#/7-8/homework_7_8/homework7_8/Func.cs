//
// Class for default algorithms
//

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace methods
{
    class alg
    {
        public static int toIntParse(string num)
        {
            return int.Parse(num);
        }
        public static float toFloatParse(string num)
        {
            return float.Parse(num);
        }
        public static int toIntTryParse(string message = "")
        {
            bool trueValue = false;

            while (!trueValue)
            {
                Console.WriteLine(message);
                string readAge = Console.ReadLine();

                if (readAge != string.Empty)
                {
                    if (int.TryParse(readAge, out int value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Не число");
                    }
                }
            }

            return -1;
        }
        public static float toFloatTryParse(string message = "")
        {
            bool trueValue = false;

            while (!trueValue)
            {
                Console.WriteLine(message);
                string readAge = Console.ReadLine();

                if (readAge != string.Empty)
                {
                    if (float.TryParse(readAge, out float value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Не число");
                    }
                }
            }

            return -1.0f;
        }

        public static void swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        public static void swap<T>(T first, T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        public static void PrintArr<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void RandFillArray(int[] array, int min = -100, int max = 100)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RAND(min, max);
            }

        }
        public static int RAND(int min, int max)
        {
            Random rand = new Random();
            return min + rand.Next() % (max - (min) + 1);
        }

        public static string randString(int cnt)
        {

            string str = string.Empty;
            str += (char)RAND('A', 'Z');
            for (int i = 1; i < cnt; i++)
            {
                str += (char)RAND('a', 'z');
            }
            return str;
        }
        public static void FillNumber(int[] array, int num, int chance = 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (RAND(1, chance) == chance) { array[i] = 0; }
            }
        }
    }

}