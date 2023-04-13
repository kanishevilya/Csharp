using System;
using static System.Console;

using CommonTools;
namespace classwork9_10 {
	//public abstract class Human { }
	//public abstract class Learner : Human { }
	//public class SchoolChild : Learner { }
	//public class Student : Learner { }
	//public abstract class Employee : Human { }

	//public interface IWorker { }

	//public sealed class Tutor : Human, IWorker { }
	//public class Scientist : Employee, IWorker { }

	//public interface IManager {
	//	public List<IWorker> Workers { get; set; }
	//}
	//public class Manager : Employee, IWorker, IManager {
	//	public List<IWorker> Workers { get; set; }
	//}
	//public class Specialist : Employee, IWorker { }
	public class Monkey {
		public string FName;
		public string LName;
	}
	public class Person {
		public string FName;
		public string LName;
	}

	public class LivingBeings<T> // where T : class
	{
		List<T> items;
		public LivingBeings() {
			items = new List<T>();
		}

		public void Add(T item){
	     items.Add(item);
		}

	}


	public class Program {

		static void Main(string[] args) {
			LivingBeings<Person> livingBeings = new LivingBeings<Person>();
			livingBeings.Add(new Person());


		}
	}
}
