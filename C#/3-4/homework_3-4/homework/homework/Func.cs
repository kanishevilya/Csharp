//
// Class for default algorithms
//
namespace methods
{
    class alg<T>
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

        public static void swap(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        public static void swap(T first, T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        public static void PrintArr(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void RandFillArray(int[] array, int min=-100, int max=100)
        {
            Random rand=new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RAND(min, max);
            }

        }
        public static int RAND(int min,int max)
        {
            Random rand = new Random();
            return min + rand.Next() % (max - (min) + 1);
        }
        public static void FillNumber(int [] array,int num , int chance = 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(RAND(1, chance) == chance) { array[i] = 0; }
            }
        }
    }

}