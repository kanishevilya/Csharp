using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using methods;

namespace classwork7_8
{
    public class Program
    {
        private static List<Human> humans;
        public static void Main(string[] args)
        {
            humans = new List<Human>();

            //Human human = new Human(1, "Ilya human", "Kujo human");
            Employee employee = new Employee(2, "Ilya employee", "Kujo employee", 500);
            Tutor tutor = new Tutor(3, "Gojo tutor", "Satoru tutor", 1000);
            Tutor tutor2 = new Tutor(3, "Gojo tutor", "Satoru tutor", 1000);
            Curator curator = new Curator(4, "Gojo Curator", "Satoru Curator", 2000);

            Console.WriteLine(employee.ToString());
            Console.WriteLine(tutor.ToString());
            Console.WriteLine(curator.ToString());

            Console.WriteLine(tutor.Equals(tutor2));

            ////humans.Add(human);
            //humans.Add(employee);
            //humans.Add(tutor);
            //humans.Add(curator);

            ////human.Print();
            ////employee.Print();
            ////tutor.Print();
            ////curator.Print();

            ////((Employee)tutor).Print();

            //foreach (var current in humans)
            //{
            //    current.Print();
            //    current.DoAction();
            //}
        }
    }
}
