using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using methods;

namespace homework7_8.Problem_01
{
    public class CompositeFigure
    {
        private List<GeometricFigure> geometricFigureList;
        private float square;


        public CompositeFigure()
        {
            geometricFigureList=new List<GeometricFigure>();
            square = 0;
        }

        public CompositeFigure(List<GeometricFigure> geometricFigureList, float square=0)
        {
            this.geometricFigureList = geometricFigureList;
            this.square = square;
        }

        public void addFigure(GeometricFigure geometricFigure)
        {
            geometricFigureList.Add(geometricFigure);
        }
        public void calcSquare()
        {
            foreach (var item in geometricFigureList)
            {
                item.calcSquare();
                square += item.SquareGet;
            }
        }
        public void Print()
        {
            Console.WriteLine("Composite figure shapes: ");
            foreach(var item in geometricFigureList)
            {
                Console.WriteLine(item.GetType().Name);
                item.PrintSides();
                Console.WriteLine($"S = {item.SquareGet}");
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine($"General Square: {square}");
        }
    }
}
