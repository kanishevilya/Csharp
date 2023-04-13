using System.Numerics;

using CommonTools;
using CommonTools.ConsoleShortCuts;

namespace homework_9_10 {
	public class Program {

		public static void Problem_01(){
			Fraction f = new Fraction(3, 4);
			Console.WriteLine($"f = {f}");
			int a = 10;
			Fraction f1 = f * a;
			Console.WriteLine($"f1 ({f} * {a}) = {f1}");
			Fraction f2 = a * f;
			Console.WriteLine($"f2 ({a} * {f}) = {f2}");
			double d = 1.5;
			Fraction f3 = f + d;
			Console.WriteLine($"f3 ({f} + {d}) = {f3}");
			if(f){
			  Console.WriteLine("true");
			}else{
			  Console.WriteLine("false");
			}

			//P.S. все перегружено
		}
		public static void Main(string[] args) {
			Console.WriteLine("Task 1)");
			Problem_01();
		}
	}

}