using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class HangingGardensOfBabylon
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public HangingGardensOfBabylon()
        {
            name = "Hanging Gardens Of Babylon";
            dateOfBuilding = "600 BC.";
            placeOfBuilding = "Babylon";
            height = 60;
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
