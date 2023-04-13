using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonTools;


//Реализовать класс для хранения комплексного числа Выполнить в нем перегрузку всех необходимых
//операторов для успешной компиляции следующего
//фрагмента кода:
//Complex z = new Complex(1, 1);
//Complex z1;
//z1 = z - (z * z * z - 1) / (3 * z * z);
//Console.WriteLine("z1 = {0}", z1);
//Краткая справка по комплексным числам
//(из Википедии):
//• Любое комплексное число может быть представлено
//как формальная сумма x + iy, где x и y — вещественные51
//Домашнее задание
//числа, i — мнимая единица, то есть число, удовлетворяющее уравнению i^2 = − 1

namespace homework_9_10 {
	public class Complex {
		private const char i = 'i';

		//x + iy
		private float x;
		private float y;

		public Complex() {
			x = 0;
			y = 0;
		}

		public Complex(float x, float y) {
			this.x = x;
			this.y = y;
		}
		public Complex(float x) {
			this.x = x;
			this.y = 0;
		}
		// '+' operators
		#region
		public static Complex operator +(Complex cFirst, Complex cSecond) {
			return new Complex(cFirst.x + cSecond.x, cFirst.y + cSecond.y);
		}
		public static Complex operator +(Complex cFirst, float num) {
			return cFirst + (Complex)num;
		}
		public static Complex operator +(float num, Complex cSecond) {
			return (Complex)num + cSecond;
		}
		#endregion
		// '-' operators
		#region
		public static Complex operator - (Complex cFirst, Complex cSecond) {
			return new Complex(cFirst.x - cSecond.x, cFirst.y - cSecond.y);
		}
		public static Complex operator -(Complex cFirst, float num) {
			return cFirst - (Complex)num;
		}
		public static Complex operator -(float num, Complex cSecond) {
			return (Complex)num- cSecond;
		}
		#endregion 
		// '*' operators
		#region
		public static Complex operator * (Complex cFirst, Complex cSecond) {
			float xTemp = cFirst.x * cSecond.x - cFirst.y * cSecond.y;
			float yTemp = cFirst.y * cSecond.x + cFirst.x * cSecond.y;
			return new Complex(xTemp, yTemp);
		}
		public static Complex operator *(Complex cFirst, float num) {
			return cFirst * (Complex)num;
		}
		public static Complex operator *(float num, Complex cSecond) {
			return cSecond * num;
		}
		#endregion 
		// '/' operators
		#region
		public static Complex operator /(Complex cFirst, Complex cSecond) {
			float xTemp = (cFirst.x * cSecond.x + cFirst.y * cSecond.y) / (float)(Math.Pow(cSecond.x, 2) + Math.Pow(cSecond.y, 2));
			float yTemp = (cFirst.y * cSecond.x - cFirst.x * cSecond.y) / (float)(Math.Pow(cSecond.x, 2) + Math.Pow(cSecond.y, 2)); ;
			return new Complex(xTemp, yTemp);
		}
		public static Complex operator /(Complex cFirst, float num) {
		  return cFirst / (Complex)num;
		}
		public static Complex operator /(float num, Complex cSecond) {
			return (Complex)num/ cSecond;
		}
		#endregion 
		public static explicit operator Complex(float num){
		   return new Complex(num);
		}
		public override string ToString() {
			string temp = y < 0 ? "-" : "+";
			return $"[{x} {temp} {Math.Abs(y)}*{i}]";
		}

	}
}
