using System;
using static System.Console;

using CommonTools;
namespace classwork9_10 {
	public class Program {


		public delegate int IntDelegate(double d);
		public delegate double CalcDelegate(double x, double y);


		class Calculator {
			public double Add(double x, double y) {
				return x + y;
			}
			public static double Sub(double x, double y) {
				return x - y;
			}
			public double Mult(double x, double y) {
				return x * y;
			}
			public double Div(double x, double y) {
				if (y != 0) {
					return x / y;
				}
				throw new Exception("x/0 ==???!?!");
			}
		}

		public static void Main(string[] args) {
			Calculator calculator = new();
			while (true) {
				WriteLine("Введите пример: ");
				string exp = ReadLine();
				char sign = ' ';

				foreach (char symbol in exp) {
					if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/') {
						sign = symbol;
						break;
					}
				}
				try {
					string[] nummers = exp.Split(sign);
					CalcDelegate del = null;
					switch (sign) {
						case '+':
						del = new CalcDelegate(calculator.Add);
						break;
						case '-':
						del = new CalcDelegate(Calculator.Sub);
						break;
						case '*':
						del = calculator.Mult;
						break;
						case '/':
						del = calculator.Div;
						break;
						default:
						throw new InvalidOperationException();
					}
					double a=double.Parse(nummers[0]);
					double b=double.Parse(nummers[1]);
					WriteLine($"Result: {del(a, b)}");
	 
		  } catch (Exception e) {
					Console.WriteLine(e.ToString());
				}
			}

		}


	}
}
