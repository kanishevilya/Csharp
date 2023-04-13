using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using CommonTools;
using CommonTools.ConsoleShortCuts;

namespace homework_9_10 {
	//Разработать собственный структурный тип данных
	//для хранения целочисленных коэффициентов A и B
	//линейного уравнения A×X + B×Y = 0 в классе реализовать статический метод Parse(), которые принимает
	//строку со значениями коэффициентов, разделенных
	//запятой или пробелом
	public struct Coefficients {
		private int A, B;
		private float D; //вспомогательная переменная
		public Coefficients() {
			A = 0;
			B = 0;
			D = 0;
		}

		public Coefficients(int a, int b) {
			A = a;
			B = b;
			D = 0;
		}

		public void Parse() {
			string firstCoef = "";
			string secondCoef = "";
			bool forswap = false;
			bool isEnd = false;
			while (!isEnd) {
				firstCoef = "";
				secondCoef = "";
				forswap = true;
				Console.WriteLine("Введите коэффиценты A и B (int), разделенных пробелом/запятой: ");

				StringBuilder sb = new StringBuilder(Console.ReadLine());
				for (int i = 0; i < sb.Length; ++i) {
					if (sb[i] != ' ' && sb[i] != ',') {
						secondCoef += sb[i];
					} else {
						if (forswap == true) {
							forswap = false;
							Alg.Swap(ref firstCoef, ref secondCoef);
						}
					}
				}

				if (int.TryParse(firstCoef, out A)) {
				} else {
					Console.WriteLine("Не число, либо нет второго коэффицента");
					continue;
				}
				if (int.TryParse(secondCoef, out B)) {
				} else {
					Console.WriteLine("Не число, либо нет второго коэффицента");
					continue;
				}
				//Console.WriteLine(A);
				//Console.WriteLine(B);
				isEnd = true;
				//Console.WriteLine(secondCoef);
			}

		}


		//Разработать метод для решения системы 2 линейных
		//уравнений:
		//A1×X + B1×Y = 0
		//A2×X + B2×Y = 0
		//Метод с помощью выходных параметров должен
		//возвращать найденное решение или ошибку, если
		//решения не существует
		public Vector2 Solution(ref Coefficients eq1, ref Coefficients eq2) {
			//т.к. оба уравнения в каждом случае равны нулю, то система не имеет смысла, т.к. в любых ситуациях корнями будут являться 0 и 0
			
			D = eq1.A * eq2.B - eq2.A * eq1.B;
			if (D == 0) { Console.WriteLine("Решений нет!!"); return new Vector2(); }
			float x, y;
			x = (0 * eq2.B - 0 * eq1.B) / D;  //т.к. в формуле используется коэф C, который у нас = 0, x и y = 0
			y = (eq1.A * 0 - eq2.A * 0) / D;
			return new Vector2(x, y);
		}
		public void AllActions(){
		  Coefficients first = new Coefficients();
		  Coefficients second = new Coefficients();
			first.Parse();
			second.Parse();
			Console.WriteLine("Решение системы: ");
			Console.WriteLine(Solution(ref first, ref second));
			if (D != 0) { Console.WriteLine("0 0 т.к. любые значения дадут 0, (недочёт условия, но реализуемо)"); }
		}
	}
}
