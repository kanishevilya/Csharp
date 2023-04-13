using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace classwork_3_4
{
    internal class WorkWithStrings_02
    {
        public void Start()
        {



            int[] array = new int[9] { 0, 4, 1, 0, 1, 0, 4, 7, 8 };
            int zeroCnt = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0) { zeroCnt++; }
                else
                {
                    array[i - zeroCnt] = array[i ];
                }
            }
            for (int i = 0; i < zeroCnt; ++i)
            {
                array[array.Length - 1 - i] = -1;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            return;
            //int[,] array=new int[,] { {4,5,5,3, }, {5,3,4, 4}, {5,4,4,4} };
            //Console.WriteLine(array[1,4]);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "000");
            dictionary.Add(1, "111");
            dictionary.Add(2, "222");
            dictionary.Add(3, "222");
            dictionary.Add(4, "222");
            foreach (var item in dictionary)
            {
                dictionary.Remove(item.Key);

                Console.WriteLine(dictionary.Count);
            }
            return;
            string textUser = Console.ReadLine();
            if(int.TryParse(textUser, out int value))
            {
                if(value >= 1 && value <= 3)
                {
                    Console.WriteLine(Enum.GetValues(typeof(Numbers)).GetValue(value-1));
                }
            }
            return;
            Console.WriteLine(Numbers.First);
            return;
            string iWork = "Я Работаю 12 Часов В День";
            StringBuilder sb= new StringBuilder(iWork);
            
            sb.Append(" 1");
            sb.Insert(2, 'P');
            sb.Replace('а', 'А');

            Console.WriteLine(sb);
            return;
            string[] arrayStrings = iWork.Split("/");
            foreach (var str in arrayStrings)
            {
                Console.WriteLine(str);
            }

            iWork = iWork.Remove(5, 1);

            Console.WriteLine(iWork);

            return;
            iWork = iWork.TrimEnd("/".ToCharArray());
            Console.WriteLine(iWork);
            return;
            iWork=iWork.PadLeft(50);
            Console.WriteLine(iWork);

            return;
            //string iWork = "Я Работаю 12 Часов В День";
            int indexTime = 0;
            if (iWork.Contains("Часов"))
            {
                indexTime = iWork.IndexOf("Часов", 0);
                iWork = iWork.Insert(indexTime, "3 ");
            }

            Console.WriteLine(iWork.ToLower());
        }
        enum Numbers
        {
            First,
            Second,
            Third,
        }
    }
}
