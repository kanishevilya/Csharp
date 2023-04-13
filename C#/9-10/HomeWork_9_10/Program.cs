using System.Numerics;

using CommonTools;
using CommonTools.ConsoleShortCuts;

namespace homework_9_10 {
	public class Program {
		public static void Problem_01() {
			Coefficients coefficients = new Coefficients();
			coefficients.AllActions();
      //В условии оба уравнения равны 0, поэтому при выражении x через y он всегда будет = 0, с y тоже самое
		}
		public static void Problem_02() {
			Complex z = new Complex(1, 1);
			Complex z1;
			z1 = z - (z * z * z - 1) / (3 * z * z);

			Console.WriteLine("z = {0}", z);
			Console.WriteLine($"z1 = {z} - ({z} * {z} * {z} - 1) / (3 * {z} * {z})");
			Console.WriteLine("z1 = {0}", z1);
			//На калькуляторе проверил, все верно

			//P.S. все перегружено
		}
		public static void Problem_03(){
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
			//if(f){
			//  Console.WriteLine("true");
			//}else{
			//  Console.WriteLine("false");
			//}

			//P.S. все перегружено
		}
		public static void Main(string[] args) {
			Console.WriteLine("Task 1)");
			Problem_01();
			Console.WriteLine("\nTask 2)");
			Problem_02();
			Console.WriteLine("\nTask 3)");
			Problem_03();
		}
	}

}