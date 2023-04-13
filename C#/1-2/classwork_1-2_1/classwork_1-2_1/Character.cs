using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstLesson
{
    public class Character
    {

        private string name;
        
        private int age;
        
        private List<Item> items;

        public Character(string name, int age, List<Item> items) {
            this.name = name;
            this.age = age;
            this.items = items;

            Console.WriteLine($"I player name: {this.name}\nAge: {this.age} items {this.items}");
        }

    }
}
