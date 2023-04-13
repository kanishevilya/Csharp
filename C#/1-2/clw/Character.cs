using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Character
    {
        private string name;
        private int age;

        private List<Item> items;

        public Character(string name, int age, List<Item> items)
        {
            this.name = name;
            this.age = age;
            this.items = items;

            Console.WriteLine($"I player name {name} age {age} items {Enum.GetName(typeof(TypeItem), items[0])} ");
        }
    }
}
