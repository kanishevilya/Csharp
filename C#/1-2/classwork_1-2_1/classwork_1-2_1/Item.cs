using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{

    internal class Item
    {
        //private string name;

        public Item(string name, TypeItem type)
        {
            Name = name;
            Type = type;
        }
        public TypeItem Type { get; private set; }
        public string Name { get; private set; }

    }
    
    public enum TypeItem
    {
        Clothe,
        Food,
        Potions
    }
}
