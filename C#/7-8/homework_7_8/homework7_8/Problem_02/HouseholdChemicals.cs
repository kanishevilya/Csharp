using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7_8.Problem_02
{
    public class HouseholdChemicals : Product
    {
        public HouseholdChemicals(string name, float price, int quantity, ProductStatus productStatus, ProductType productType = ProductType.HouseholdChemicals) : base(name, price, quantity, productStatus, productType)
        {

        }

        public override void Print()
        {
            Console.WriteLine("(HouseholdChemicals) class");
            base.Print();
        }
    }
}
