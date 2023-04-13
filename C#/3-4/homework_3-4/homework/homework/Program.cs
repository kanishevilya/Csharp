//1.Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
//2. Преобразовать массив так, чтобы сначала шли все
//отрицательные элементы, а потом положительные
//(0 считать положительным)
//3.Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
//встречается в массиве.
//4. В двумерном массиве порядка M на N поменяйте
//местами заданные столбцы.

using methods;

namespace homework_3_4
{
    class homework{

        //1.Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
        void Problem_01()
        {

            int[] array;
            int size = alg<string>.toIntTryParse("Enter array size: ");

            array= new int[size];
            alg<int>.RandFillArray(array); //заполняет массив случайными числами
            alg<int>.FillNumber(array,0, 3); //заполняет массив числом с определенным шансом 
            
            Console.WriteLine("Array: ");
            alg<int>.PrintArr(array);

            int zeroCnt = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0) { zeroCnt++; }
                else
                {
                    array[i - zeroCnt] = array[i];
                }
            }
            for (int i = 0; i < zeroCnt; ++i)
            {
              array[array.Length - 1 - i] = -1;
            }
            Console.WriteLine("Ready array without Zeros: ");
            alg<int>.PrintArr(array);

        }
        //2. Преобразовать массив так, чтобы сначала шли все
        //отрицательные элементы, а потом положительные
        //(0 считать положительным)
        void Problem_02()
        {
            int[] array;
            int size = alg<string>.toIntTryParse("Enter array size: ");

            array = new int[size];
            int[] arrayTempForNegative = new int[size];
            alg<int>.RandFillArray(array); //заполняет массив случайными числами

            Console.WriteLine("Array: ");
            alg<int>.PrintArr(array);

            int negCnt = 0;
            for (int i = 0, n=0; i < array.Length; ++i)
            {
                if (array[i] < 0) { arrayTempForNegative[n++] = array[i]; negCnt++; }
                else
                {
                    array[i - negCnt] = array[i];
                }
            }
            for (int i = 0; i < negCnt; ++i)
            {
                array[array.Length - 1 - i] = arrayTempForNegative[negCnt-1- i];
            }
            Console.WriteLine("Ready array: ");
            alg<int>.PrintArr(array);
        }

        //3.Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
        //встречается в массиве.
        void Problem_03()
        {
            int[] array;
            int size = alg<string>.toIntTryParse("Enter array size: ");

            array = new int[size];
            alg<int>.RandFillArray(array,0,10); //заполняет массив случайными числами
            Console.WriteLine("Array: ");
            alg<int>.PrintArr(array);

            int num = alg<int>.toIntTryParse("Enter a number: ");
            int cnt = 0;
            foreach (var cell in array)
            {
                if (cell == num) { cnt++; }
            }
            Console.WriteLine($"Count = {cnt}");
        }
        //4. В двумерном массиве порядка M на N поменяйте
        //местами заданные столбцы.
        void Problem_04()
        {
            int[][] array;

            int columns = 0;
            int rows = 0;
            rows = alg<int>.toIntTryParse("Enter a rows count for array: ");
            columns = alg<int>.toIntTryParse("Enter a columns count for array: ");

            array = new int[rows][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[columns];
                alg<int>.RandFillArray(array[i], 0, 40);
            }
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0,5}", $"{array[i][j]} ");
                }
                Console.WriteLine();
            }
            int colum1 = 0;
            int colum2=0;
            while((colum1 = alg<int>.toIntTryParse("Enter a column1 for swap: "))<=0 || colum1>array.Length);
            while((colum2 = alg<int>.toIntTryParse("Enter a column2 for swap: "))<=0 || colum2>array.Length);
            colum1--;
            colum2--; 
            //if(colum1 == colum2) { return; }
            if(colum2 < colum1) { alg<int>.swap(ref colum2, ref colum1); }

            for (int i = 0; i < array.Length; i++)
            {
                alg<int>.swap(ref array[i][colum1], ref array[i][colum2]);
            }

            Console.WriteLine("Swaped Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0,5}", $"{array[i][j]} ");
                }
                Console.WriteLine();
            }


        }

        public static void Main(string[] args)
        {
            homework hw = new homework();

            hw.Problem_01();
            hw.Problem_02();
            hw.Problem_03();
            hw.Problem_04();

        }

    }



}