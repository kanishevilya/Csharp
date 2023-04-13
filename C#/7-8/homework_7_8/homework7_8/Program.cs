using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using methods;

using homework7_8.Problem_01;
using homework7_8.Problem_02;

namespace homework7_8
{
    public class Program
    {

        public static void Problem_01()
        {
            Square square = new Square();
            square.AllActions();
            square.Print();

            Console.WriteLine();
            Circle circle = new Circle();
            circle.AllActions();
            circle.Print();

            Console.WriteLine();
            Triangle triangle = new Triangle();
            triangle.AllActions();
            triangle.Print();
            Console.WriteLine();
            Console.WriteLine();
            CompositeFigure compositeFigure = new CompositeFigure();
            compositeFigure.addFigure(square);
            compositeFigure.addFigure(circle);
            compositeFigure.addFigure(triangle);
            compositeFigure.calcSquare();
            compositeFigure.Print();
        }
        public static void Problem_02()
        {
            Order order = new Order();
            order.addProduct(new FoodStuffs("Milk", 940, 51, ProductStatus.WrittenOff));
            order.addProduct(new Furniture("Table", 10400, 14, ProductStatus.Transferred));
            order.addProduct(new Electronics("SmartPhone", 120100, 40, ProductStatus.Came));
            order.addProduct(new HouseholdChemicals("Fairy", 890, 93, ProductStatus.Implemented));
            order.Print();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Problem_01\n");
            Problem_01();
            Console.WriteLine("\n\nProblem_02\n");
            Problem_02();

        }
    }
}
