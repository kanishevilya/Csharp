using System;

namespace classwork_3_4 {


    public class Program {
        public static void Main(string[] args)
        {
            WorkWithStrings_02 task=new WorkWithStrings_02();
            task.Start();
            #region
            ////int i = int.Parse(Console.ReadLine());
            ////Console.WriteLine(i);
            //bool isTrueNum = false;
            //string textUser = "";
            //string temp = "";
            //int idx1 = -1;
            //int idx2 = -1;
            //while (!isTrueNum)
            //{
            //    Console.WriteLine("Enter a six-digit number: ");
            //    textUser = Console.ReadLine();
            //    if (int.TryParse(textUser, out int result))
            //    {
            //        if (textUser.Length != 6) { Console.WriteLine("Nmber is not a six-digit!"); continue; }
            //        isTrueNum = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect value!");
            //    }
            //}

            //isTrueNum = false;
            //while (!isTrueNum)
            //{
            //    Console.WriteLine("Enter first index of the number: ");
            //    temp = Console.ReadLine();
            //    if (int.TryParse(temp, out int result))
            //    {
            //        if (result > 0 && result < 7)
            //        {
            //            if (idx1 == 0)
            //            {
            //                idx1 = result;
            //            }
            //            else
            //            {
            //                if (idx1 == result)
            //                {
            //                    Console.WriteLine("Одинаковые числа!");
            //                }
            //                idx2 = result;
            //                isTrueNum = true;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect value!");
            //        }
            //    }
            //}


            //idx1--;
            //idx2--;

            //char[] charsText = textUser.ToCharArray();
            //char firstChar = charsText[idx1];
            //charsText[idx1] = charsText[idx2];
            //charsText[idx2] = firstChar;

            //string resultText = new string(charsText);

            //Console.WriteLine($"Result = {resultText}");

            #endregion
        }


    }


}
