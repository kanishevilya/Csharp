using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonTools;

namespace homework_9_10 {
	public class Fraction {
		private double numerator;
		private double denominator;

		public Fraction() {
			numerator = 0f;
			denominator = 1f;
		}
		public Fraction(double numerator){
	    this.numerator = numerator;
			denominator = 1f;
		}
		public Fraction(double numerator, double denominator) {
			this.numerator = numerator;
			this.denominator = denominator;
		}

		// '+' operators
		#region
		public static Fraction operator +(Fraction fFirst, Fraction fSecond) {
			double numTemp = (fFirst.numerator * fSecond.denominator) + (fSecond.numerator * fFirst.denominator);
			double denTemp = fFirst.denominator * fSecond.denominator;
			return new Fraction(numTemp, denTemp);
		}
		public static Fraction operator +(Fraction fFirst, double num) {
			return fFirst + (Fraction)num;
		}
		public static Fraction operator +(double num, Fraction fSecond) {
			return (Fraction)num + fSecond;
		}
		#endregion
		
		// '-' operators
		#region
		public static Fraction operator -(Fraction fFirst, Fraction fSecond) {
			double numTemp = (fFirst.numerator * fSecond.denominator) - (fSecond.numerator * fFirst.denominator);
			double denTemp = fFirst.denominator * fSecond.denominator;
			return new Fraction(numTemp, denTemp);
		}
		public static Fraction operator -(Fraction fFirst, double num) {
			return fFirst - (Fraction)num;
		}
		public static Fraction operator -(double num, Fraction fSecond) {
			return (Fraction)num - fSecond;
		}
		#endregion
		
		// '*' operators
		#region
		public static Fraction operator *(Fraction fFirst, Fraction fSecond) {
			double numTemp = fFirst.numerator * fSecond.numerator;
			double denTemp = fFirst.denominator * fSecond.denominator;
			return new Fraction(numTemp, denTemp);
		}
		public static Fraction operator *(Fraction fFirst, double num) {
			return fFirst * (Fraction)num;
		}
		public static Fraction operator *(double num, Fraction fSecond) {
			return fSecond * num;
		}
		#endregion
		
		// '/' operators
		#region
		public static Fraction operator /(Fraction fFirst, Fraction fSecond) {
			double numTemp = fFirst.numerator * fSecond.denominator;
			double denTemp = fFirst.denominator * fSecond.numerator;
			return new Fraction(numTemp, denTemp);
		}
		public static Fraction operator /(Fraction fFirst, double num) {
			return fFirst / (Fraction)num;
		}
		public static Fraction operator /(double num, Fraction fSecond) {
			return (Fraction)num / fSecond;
		}
		#endregion

		// 'true', 'false' operators
		#region
		public static bool operator true(Fraction fFirst) {
			return fFirst.numerator <= fFirst.denominator;
		}
		public static bool operator false(Fraction fFirst) {
			return !(fFirst.numerator <= fFirst.denominator);
		}
		#endregion

		// '==', '!='
		#region
		public static bool operator ==(Fraction fFirst, Fraction fSecond) {
			return fFirst.numerator*fSecond.denominator == fSecond.numerator*fFirst.denominator;
		}
		public static bool operator !=(Fraction fFirst, Fraction fSecond) {
			return !(fFirst==fSecond);
		}
		#endregion

		// '>', '<'
		#region
		public static bool operator >(Fraction fFirst, Fraction fSecond) {
			return fFirst.numerator * fSecond.denominator > fSecond.numerator * fFirst.denominator;
		}
		public static bool operator <(Fraction fFirst, Fraction fSecond) {
			return fFirst.numerator * fSecond.denominator < fSecond.numerator * fFirst.denominator;
		}
		#endregion
		public static explicit operator Fraction(double num){
	     return new Fraction(num);
		}
		public override string ToString() {
			return $"[{numerator} / {denominator}]";
		}

	}
}
