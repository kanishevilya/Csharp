using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7_8.Problem_02
{
    public class Furniture : Product
    {
        public Furniture(string name, float price, int quantity, ProductStatus productStatus, ProductType productType = ProductType.Furniture) : base(name, price, quantity, productStatus, productType)
        {

        }

        public override void Print()
        {
            Console.WriteLine("(Furniture) class");
            base.Print();
        }
    }
}
