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
        public static int toIntTryParse(string message="")
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

        public static void swap(T first, T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

    }

}