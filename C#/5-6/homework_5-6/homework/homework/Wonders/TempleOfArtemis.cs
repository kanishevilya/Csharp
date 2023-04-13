using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class TempleOfArtemis
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public TempleOfArtemis()
        {
            name = "Temple Of Artemis";
            dateOfBuilding = "550 BC.";
            placeOfBuilding = "Ephesus";
            height = 18;
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
