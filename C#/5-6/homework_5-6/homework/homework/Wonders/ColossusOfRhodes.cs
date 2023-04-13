using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class ColossusOfRhodes
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public ColossusOfRhodes()
        {
            name = "Colossus Of Rhodes";
            dateOfBuilding = "280 BC.";
            placeOfBuilding = "Rhode";
            height = 150;
        }
        public void print()
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Date of building = {dateOfBuilding}");
            Console.WriteLine($"Place of building = {placeOfBuilding}");
            Console.WriteLine($"Height = {height}");
        }
    }
}
