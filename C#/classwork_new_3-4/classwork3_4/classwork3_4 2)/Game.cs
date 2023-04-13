using System;
using static System.Console;

using CommonTools;

namespace classwork3_4 {
	public class Game {
		private int size;
		private RandomString randomStringForFind;
		private string wholeStr;
		private List<char> myList;
		private bool isEnd;
		private bool isWin;
		private bool isAttemptsOver;
		private int Attempt;
		private List<int> indexes;
		public Game() {
			size = 0;
			randomStringForFind = new RandomString();
			indexes = new List<int>();
			myList = new List<char>();
			isEnd = false;
			isWin = false;
			isAttemptsOver = false;
			Attempt = 1;
			wholeStr = string.Empty;
		}
		public void Start() {
			size = randomStringForFind.Length;
			randomStringForFind.FillNumber();
			WriteLine(randomStringForFind.FullString);
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
		public bool IsLose(){ isAttemptsOver= Attempt > 0 ? false : true; return isAttemptsOver; }
		public bool IsWin() {

			 return myList == randomStringForFind.Word || isWin;
		}
		public void PrintInfo() {
			ForegroundColor = ConsoleColor.Green;
			WriteLine("You have several options:\n1) Guess the word\n2) Write the word by symbols\n0) Exit");
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
				  wholeStr = string.Empty;
				  while (wholeStr == string.Empty || wholeStr.Length != randomStringForFind.Length) {WriteLine($"Enter a Whole string size(>0 && <{randomStringForFind.Length}): "); wholeStr = ReadLine(); }
				  if (checkWhole()) { isWin = true; break; }else{ WriteLine("Did not guess!"); }
				  break;
				case 2:
				  indexes.Clear();
				  myList.Clear();
				  char temp = '\0';
				  for (int i = 0; i < randomStringForFind.Length; ++i) {
				  	while (temp=='\0') { Write($"{i+1}) "); temp = (ReadLine())[0]; }
				  	myList.Add(temp);
				  	temp = '\0';
				  	//if (temp == randomNumberForFind.Number[i]) {
				  	//	indexes.Add(i);
				  	//}
				  }
				  setIndexes();
				  printIndexes();
				  isWin = true;
				  for (int i = 0; i < indexes.Count - 1; i++) {
				  	if (indexes[i] != indexes[i + 1] - 1 || indexes.Count != randomStringForFind.Length) { isWin = false; break; }
				  }
				  break;
			}
		}
		public bool checkWhole() {
			return wholeStr == randomStringForFind.FullString;
		}
		public void setIndexes() {
			indexes.Clear();
			for (int i = 0; i < randomStringForFind.Length; i++) {
				if (myList[i] == randomStringForFind.Word[i]) {
					indexes.Add(i);
				}
			}
		}
		public void printIndexes() {
			Write("Indexes that match: ");
			foreach (int i in indexes) {
				Write($"{i+1} [{randomStringForFind.Word[i]}]  ");
			}
		  WriteLine();
		}
	}
}
