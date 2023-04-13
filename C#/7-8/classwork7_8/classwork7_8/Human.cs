using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork7_8
{
    public abstract class Human
    {
        private int id;
        private string firstName;
        private string lastName;

        public Human(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public virtual void DoAction()
        {
            Console.WriteLine("Action human");
        }
        public virtual void Print()
        {
            Console.WriteLine($"First name = {firstName} | last name = {lastName}");
        }
    }
}
