using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class StatueOfZeusAtOlympia
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public StatueOfZeusAtOlympia()
        {
            name = "Statue Of Zeus At Olympia";
            dateOfBuilding = "435 BC.";
            placeOfBuilding = "Olympia";
            height = 17;
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
