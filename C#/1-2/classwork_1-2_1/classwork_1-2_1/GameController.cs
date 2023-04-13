using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    public class GameController
    {

        private Character player;
        private int countStartItems = 5;

        public void StartGame()
        {
            CreatePlayer();
            
            
        }
        private void CreatePlayer()
        {
            string namePlayer = Program.Interact.ReadNamePlayer();
            int agePlayer = Program.Interact.ReadAgePlayer();
            //Console.WriteLine($"name = {namePlayer} age={agePlayer}");

            player = new Character(namePlayer, agePlayer, CreateStartItems());
        }

        private List<Item> CreateStartItems()
        {
            List<Item> items = new List<Item>();

            for (int i = 0; i < countStartItems; ++i)
            {
                string name = $"Item_{i}";
                int random = new Random().Next(0, Enum.GetValues(typeof(TypeItem)).Length-1);
                TypeItem type = (TypeItem)random;
                items.Add(new Item(name, type));
            }
            return items;
        }
    }
}
