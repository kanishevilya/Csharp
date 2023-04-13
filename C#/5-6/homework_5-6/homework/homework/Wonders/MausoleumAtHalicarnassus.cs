using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class MausoleumAtHalicarnassus
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public MausoleumAtHalicarnassus()
        {
            name = "Mausoleum At Halicarnassus";
            dateOfBuilding = "351 BC.";
            placeOfBuilding = "Halicarnassus";
            height = 20;
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
