using System;
using static System.Console;

using CommonTools;

namespace classwork3_4 {

	public class RandomString {
		public List<string> Words;
		private int length;
		private List<char> word;
		private string fullString;

		public string FullString { get => fullString; }
		public int Length { get => length; }
		public List<char> Word { get => word; private set => word = value; }

		public RandomString() {

			length = 0;
			word = new List<char>();
			Words=new List<string>();
			fullString = string.Empty;
			RandWords();
		}
		public RandomString(int length) {
			this.length = length;
			this.word = new List<char>();
			Words = new List<string>();
			fullString = string.Empty;
			RandWords();
		}
		public void setListSize(int length) {
			this.length = length;
			//FillNumber();
		}
		public void FillNumber() {
			fullString = Words[Alg.RAND(0, Words.Count - 1)];
			length = fullString.Length;
			WordCalc();
		}
		public void WordCalc() {
			for (int i = 0; i < length; i++) {
				word.Add(fullString[i]);
			}
		}
		public override string ToString() {
			string str = "Number: ";
			foreach (int i in word) {
				str += i.ToString();
			}
			return str;
		}
		public void RandWords(){
			Words.Add("shovel");
			Words.Add("bin");
			Words.Add("hyperbola");
			Words.Add("donation");
			Words.Add("boot");
			Words.Add("swear");
		}
	}
}
