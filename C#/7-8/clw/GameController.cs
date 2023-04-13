namespace FirstApp
{
    public class GameController : Singletone<GameController>
    {
        private int countStartItems = 5;

        private Player player;
        private TypeActionsPlayer currentAction;


        public Character GetPlayer { get => player; }




        public void StartGame()
        {
            //interact = Program.Interact;
            CreatePlayer();

            NewCircleGame(true);
        }

        private void CreatePlayer()
        {
            //string namePlayer = interact.ReadNamePlayer();
            //int agePlayer = interact.ReadNumber("Enter a age: ");

            string namePlayer = "Player";
            int agePlayer = 26;


            player = new Player(namePlayer, agePlayer, CreateStartItems());
        }

        private List<Item> CreateStartItems()
        {
            List<Item> items = new List<Item>();

            for (int i = 0; i < countStartItems; i++)
            {
                string name = $"Item_{i}";
                int random = new Random().Next(0, Enum.GetValues(typeof(TypeItem)).Length - 1);
                TypeItem type = (TypeItem)random;

                items.Add(new Item(name, type));
            }

            return items;
        }

        private void NewCircleGame(bool isNeedClear = false)
        {
            if (isNeedClear)
            {
                UserInteract.Instance.ClearConsole();
            }
            //UserInteract.Instance.ClearConsole();
            UserInteract.Instance.ViewDataPlayer();
            UserInteract.Instance.ViewPossibleActions();
            //interact.ShowError("Error");

            DoAction((int)UserInteract.Instance.GetSelectedAction());
        }
        private void DoAction(int select)
        {
            bool isNeedClear = true;
            bool isExit = false;
            while (!isExit)
            {

                switch ((TypeActionsPlayer)select)
                {
                    case TypeActionsPlayer.ViewItems:
                        UserInteract.Instance.ViewDataPlayerItems();
                        NewCircleGame();
                        break;
                    case TypeActionsPlayer.LookAround:
                        //UserInteract.Instance.ViewPossibleActions();
                        NewCircleGame();
                        break;
                    default:
                        UserInteract.Instance.ShowError($"Not have a action with index {select}");
                        //isExit = true;
                        break;

                }
            }
        }

    }
}
