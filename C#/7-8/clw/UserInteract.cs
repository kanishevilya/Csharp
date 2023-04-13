using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class UserInteract : Singletone<UserInteract>
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

        public int ReadNumber(string message)
        {
            bool trueValue = false;

            while (!trueValue)
            {
                Console.WriteLine(message);
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
        
        public void ClearConsole()
        {
            Console.Clear();
        }
        public void ViewDataPlayer()
        {
            Character player = GameController.Instance.GetPlayer;

            Console.WriteLine(player.ToString());

        }

        public void ViewPossibleActions()
        {
            List<TypeActionsPlayer> actions = GameController.Instance.GetPlayer.GetActions;
            
            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine($"{i+1} - {actions[i]}");
            }
            
        }
        public TypeActionsPlayer GetSelectedAction()
        {
            List<TypeActionsPlayer> actions = GameController.Instance.GetPlayer.GetActions;

            int selectValue = ReadNumber("Выберите действие: ")-1;

            if(selectValue < 0 || selectValue >= actions.Count )
            {
                selectValue=(int)GetSe lectedAction();
            }
            return (TypeActionsPlayer)selectValue;
        }

        public void ViewDataPlayerItems()
        {
            List<Item> items = GameController.Instance.GetPlayer.GetItems;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i} - {items[i].Type}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public enum TypeActionsPlayer
    {
        None = -1,
        ViewItems,
        LookAround
    }

}
