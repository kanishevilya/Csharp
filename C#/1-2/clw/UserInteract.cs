using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class UserInteract
    {
        private string defaultName = "Player";
        private string namePlayer;
        private int agePlayer = 0;

        public string ReadNamePlayer()
        {
            Console.WriteLine("Введите имя: ");
            namePlayer = Console.ReadLine();

            if (namePlayer == "")
            {
                namePlayer = defaultName;
            }

            return namePlayer;
        }

        public int ReadAgePlayer()
        {
            bool trueValue = false;

            while (!trueValue)
            {
                Console.WriteLine("Введите возраст: ");
                string readAge = Console.ReadLine();

                if (readAge != string.Empty)
                {
                    if (int.TryParse(readAge, out int tryAge))
                    {
                        agePlayer = tryAge;
                        trueValue = true;
                    }
                    else
                    {
                        Console.WriteLine("Не число");
                    }
                }
            }

            return agePlayer;
        }

        // TODO: View actions player
    }
}
