using System;
using static System.Console;

using CommonTools;

namespace classwork3_4 {
	public class RandomNumberForFind {
		private int length;
		private List<int> number;
		private Int64 fullNumber;
		
		public Int64 FullNumber{ get => fullNumber; }
		public int Length{ get => length; }
		public List<int> Number { get => number; private set => number = value; }

		public RandomNumberForFind() { 
		  length = 0;
			number = new List<int>();
			fullNumber= new Int64();
		}
		public RandomNumberForFind(int length) {
			this.length = length;
			this.number = new List<int>();
			fullNumber = new Int64();
		}
		public RandomNumberForFind(int length, List<int> number) {
			this.length = length;
			this.number = number;
			fullNumber = new Int64();
		}
		public void setListSize(int length) {
			this.length = length;
			//FillNumber();
		}
		public void FillNumber(){
			number.Add(Alg.RAND(1, 9));
			for (int i = 1; i < length; ++i) {
				number.Add(Alg.RAND(0, 9));
			}
			FullNumberCalc();
		}
		public void FullNumberCalc(){
			for (int i = 0; i < length; i++) {
				fullNumber += number[i];
				fullNumber *= 10;
			}
			fullNumber /= 10;
		}
		public override string ToString() {
			string str="Number: ";
			foreach (int i in number) {
				str += i.ToString()+' ';
			}
			return str;
		}
	}
}
