namespace FirstApp
{
    public class GameController
    {
        private int countStartItems = 5;

        private Character player;

        public void StartGame()
        {
            CreatePlayer();
        }

        private void CreatePlayer()
        {
            string namePlayer = Program.Interact.ReadNamePlayer();
            int agePlayer = Program.Interact.ReadAgePlayer();

            player = new Character(namePlayer, agePlayer, CreateStartItems());
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
    }
}
