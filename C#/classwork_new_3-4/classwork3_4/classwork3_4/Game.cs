using System;
using static System.Console;

using CommonTools;

namespace classwork3_4 {
	public class Game {
		private int size;
		private RandomNumberForFind randomNumberForFind;
		private Int64 wholeNum;
		private List<int> myList;
		private bool isEnd;
		private bool isWin;
		private bool isLose;
		private int Attempt;
		private List<int> indexes;
		public Game() {
			size = 0;
			randomNumberForFind = new RandomNumberForFind();
			indexes = new List<int>();
			myList = new List<int>();
			isEnd = false;
			isWin = false;
			isLose = false;
			Attempt = 1;
			wholeNum = 0;
		}
		public void Start() {
			while (size <= 0) { size = Alg.TryInt("Enter the size of the number to generate (>0): "); }
			randomNumberForFind.setListSize(size);
			randomNumberForFind.FillNumber();
			//WriteLine(randomNumberForFind);
			while (!isEnd) {
				PrintInfo();
				//Console.WriteLine(randomNumberForFind.FullNumber);
				SelectMenu();

				Attempt--;
				if (IsWin()) { WriteLine(); WriteLine("WIN!!"); isEnd = true; isWin = true; continue; }
				if (IsLose()){ WriteLine(); WriteLine("LOSE!!"); isEnd = true; isWin = false; continue; }
			}
			Console.WriteLine("Try again? 1-y/0-n");
			int sel = -1;
			while (sel != 0 && sel != 1) { sel = Alg.TryInt(); }

			if (sel == 1){ myList.Clear(); indexes.Clear(); isEnd = false; isWin = false; Start();  }
			else{ return; }
		}
		public bool IsLose(){ isLose= Attempt > 0 ? false : true; return isLose; }
		public bool IsWin() {

			return myList == randomNumberForFind.Number || isWin;
		}
		public void PrintInfo() {
			ForegroundColor = ConsoleColor.Green;
			WriteLine("You have several options:\n1) Guess the number\n2) Write the number by digits\n0) Exit");
			WriteLine($"Attempts: {Attempt}");
			ResetColor();
		}
		public void SelectMenu() {
			int select = -1;
			while (select < 0 || select > 2) { select = Alg.TryInt(); }
			switch (select) {
				case 0:
				isEnd = true;
				break;
				case 1:
				  wholeNum = 0;
				  while (wholeNum <= 0) { wholeNum = Alg.TryInt($"Enter a Whole num (>0 && <10^{randomNumberForFind.Length}):"); }
				  if (checkWhole()) { isWin = true; break; }else{ WriteLine("Did not guess!"); }
				  break;
				case 2:
				  indexes.Clear();
				  myList.Clear();
				  int temp = -1;
				  for (int i = 0; i < size; ++i) {
				  	while (temp < 0 || temp >= 10) { temp = Alg.TryInt($"[>=0 && <10] {i+1}) "); }
				  	myList.Add(temp);
				  	temp = -1;
				  	//if (temp == randomNumberForFind.Number[i]) {
				  	//	indexes.Add(i);
				  	//}
				  }
				  setIndexes();
				  printIndexes();
				  for (int i = 0; i < indexes.Count - 1; i++) {
				  	if (indexes[i] != indexes[i + 1] - 1 || indexes.Count != randomNumberForFind.Length) { isWin = false; break; }
				  }
				  break;
			}
		}
		public bool checkWhole() {
			return wholeNum == randomNumberForFind.FullNumber;
		}
		public void setIndexes() {
			indexes.Clear();
			for (int i = 0; i < size; i++) {
				if (myList[i] == randomNumberForFind.Number[i]) {
					indexes.Add(i);
				}
			}
		}
		public void printIndexes() {
			Write("Indexes that match: ");
			foreach (int i in indexes) {
				Write($"{i+1} [{randomNumberForFind.Number[i]}]  ");
			}
		  WriteLine();
		}
	}
}
