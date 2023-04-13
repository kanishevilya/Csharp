using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework_1_2
{
    public class Problems
    {
        public int CheckStringInt(string message = "", string strReady="")
        {
            if (strReady != "")
            {
                return int.Parse(strReady);
            }
            else
            {
                string str = string.Empty;
                while (true)
                {
                    Console.WriteLine(message);
                    str = Console.ReadLine();

                    if (int.TryParse(str, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value!");
                    }

                }
            }
        }
        //        Задание 1
        //Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
        //остатка) нужно вывести слово Fizz.Если число кратно 5
        //нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
        //вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
        //вывести само число.
        //Если пользователь ввел значение не в диапазоне от 1
        //до 100 требуется вывести сообщение об ошибке.


        public void Problem_01()
        {
            Console.WriteLine("\nTask 1\n");
            Console.WriteLine("Number (1-100)");
            int num = -1;

            while (num < 1 || num > 100) { num = CheckStringInt("Enter a number (1-100): "); }

            if (num % 3 == 0 || num % 5 == 0)
            {
                if (num % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                if (num % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Number: {num}");
            }
        }

        //        Задание 2
        //Пользователь вводит с клавиатуры два числа.Первое
        //число — это значение, второе число процент, который
        //необходимо посчитать.Например, мы ввели с клавиатуры
        //90 и 10. Требуется вывести на экран 10 процентов от 90.
        //Результат: 9.

        public void Problem_02()
        {
            Console.WriteLine("\nTask 2\n");
            Console.WriteLine("Number (n) | Percent (n)");
            float num = -1.0f;
            float percent = -1.0f;
            float result = 0;
            num = CheckStringInt("Enter a number: ");
            percent = CheckStringInt("Enter a percent (any number): ");
            result = num * percent / 100;
            Console.WriteLine($"Percent result: {result}");
        }

        //        Задание 3
        //Пользователь вводит с клавиатуры четыре цифры.
        //Необходимо создать число, содержащее эти цифры.Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
        //сформировать число 1578.
        public void Problem_03()
        {
            Console.WriteLine("\nTask 3\n");
            Console.WriteLine("Number1 | Number2 | Number3 | Number4 (n>0 && n<10)");
            int num1 = -1;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            int result = -1;

            while (num1 < 0 || num1 >= 10) { num1 = CheckStringInt("Enter a number 1 (>0 && <10): "); }
            while (num2 < 0 || num2 >= 10) { num2 = CheckStringInt("Enter a number 2 (>0 && <10): "); }
            while (num3 < 0 || num3 >= 10) { num3 = CheckStringInt("Enter a number 3 (>0 && <10): "); }
            while (num4 < 0 || num4 >= 10) { num4 = CheckStringInt("Enter a number 4 (>0 && <10): "); }
            result = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            Console.WriteLine($"Result: {result}");
        }

        //        Задание 4
        //Пользователь вводит шестизначное число.После чего
        //пользователь вводит номера разрядов для обмена цифр.
        //Например, если пользователь ввёл один и шесть — это
        //значит, что надо обменять местами первую и шестую
        //цифры.
        //Число 723895 должно превратиться в 523897.
        //Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

        public void Problem_04()
        {
            Console.WriteLine("\nTask 4\n");
            Console.WriteLine("Number1 | idx1 | idx2");
            int idxfirst = -1;
            int idxlast = -1;
            int userNumber = -1;
            while(userNumber < 100000 || userNumber >= 1000000) { userNumber = CheckStringInt("Enter a number (>99999 && <1000000): "); }
            string userString = userNumber.ToString();
            while (idxfirst <= 0 || idxfirst >= userString.Length) { idxfirst = CheckStringInt($"Enter a idx1 (>0 && <{userString.Length}): "); }
            while (idxlast <= 0 || idxlast >= userString.Length) { idxlast = CheckStringInt($"Enter a idx2 (>0 && <{userString.Length}): "); }

            idxfirst--;
            idxlast--;

            char[] userCharString = userString.ToCharArray();
            char tempChr = userCharString[idxfirst];
            userCharString[idxfirst] = userCharString[idxlast];
            userCharString[idxlast] = tempChr;

            string resultText = new string(userCharString);
            userNumber = CheckStringInt("", resultText);
            Console.WriteLine($"Result = {userNumber}");
        }

        //        Задание 5
        //Пользователь вводит с клавиатуры дату.Приложение должно отобразить название сезона и дня недели.
        //Например, если введено 22.12.2021, приложение должно
        //отобразить Winter Wednesday
        public void Problem_05()
        {
            Console.WriteLine("\nTask 5\n");
            int year = -1;
           int month = -1;
           int day = -1;
           while(year < 0) { year = CheckStringInt("Enter a year (>0): "); }
           while(month < 0 || month >12) { month = CheckStringInt("Enter a month (>0 && <=12): "); }
           while(day < 0) { day = CheckStringInt("Enter a day (>0): "); }
           DateTime dt = new DateTime(year, month, day);
           string yearSeason = string.Empty;
           month = dt.Month;
           if(month == 12 || (month > 0 && month < 3)) { yearSeason = "Winter"; }
           else if(month >= 3 && month < 6) { yearSeason = "Spring"; }
           else if(month >= 6 && month < 9) { yearSeason = "Summer"; }
           else if(month >= 9 && month < 11) { yearSeason = "Autumn"; }
           Console.WriteLine(yearSeason+ " " + dt.DayOfWeek);
        }

        //        Задание 6
        //Пользователь вводит с клавиатуры показания температуры.В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
        //или наоборот.

        public void Problem_06()
        {
            Console.WriteLine("\nTask 6\n");
            float degree = 0.0f;
            Console.WriteLine("Enter a degree: ");
            degree = float.Parse(Console.ReadLine()); //делал без проверки
            int key = -1;
            bool isCelsius = true;
            while (key != 0)
            {
                Console.WriteLine("1.ToCelsius");
                Console.WriteLine("2.ToFahrenheit");
                Console.WriteLine("0.Exit");
                Console.WriteLine($"Your degree: {degree}");
                Console.WriteLine();
                key = CheckStringInt("Enter a key: ");
                if (key == 1)
                {
                    if (!isCelsius)
                    {
                        degree = -(32 - degree) / 1.8f;
                        isCelsius = true;
                    }                   
                }else if (key == 2)
                {
                    if (isCelsius)
                    {
                        degree = degree*1.8f+32;
                        isCelsius = false;
                    }
                }
            }            
        }

        //        Задание 7
        //Пользователь вводит с клавиатуры два числа.Нужно
        //показать все четные числа в указанном диапазоне.Если
        //границы диапазона указаны неправильно требуется произвести нормализацию границ.Например, пользователь
        //ввел 20 и 11, требуется нормализация, после которой
        //начало диапазона станет равно 11, а конец 20
        public void Problem_07()
        {
            Console.WriteLine("\nTask 7\n");
            int num1 = -1;
            int num2 = -1;

            num1 = CheckStringInt("Enter num1: ");
            num2 = CheckStringInt("Enter num2: ");

            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine();
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
