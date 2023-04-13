using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondersOfTheWorld
{
    public class GreatPyramidOfGiza //лучше использовать наследование, но на момент занятия мы их не прошли
    {
        private string name;
        private string dateOfBuilding;
        private string placeOfBuilding;
        private int height;

        public GreatPyramidOfGiza()
        {
            name = "Great Pyramid Of Giza";
            dateOfBuilding = "2550 BC.";
            placeOfBuilding = "Giza";
            height = 139;
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
