using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class LighthouseOfAlexandria
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public LighthouseOfAlexandria()
        {
            name = "Lighthouse Of Alexandria";
            dateOfBuilding = "3rd century BC.";
            placeOfBuilding = "Alexandria";
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
