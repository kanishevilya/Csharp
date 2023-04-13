using System;
using static System.Console;

using CommonTools;

namespace classwork7_8 {
	public class Game {
		private int x, y;
		private SeaBattle seaBattle;

		bool isGameOver;
		public Game() {
			seaBattle = new SeaBattle();
			x = 0;
			y = 0;
		}
		public void Start() {
			seaBattle.SetLists();
			seaBattle.Fill();

			seaBattle.PrintHidden();
			Console.WriteLine();
			seaBattle.PrintOpen();
			Console.WriteLine();

		}

		public void checkStep() {

			if (seaBattle.Hidden[y][x] == 1) {

				seaBattle.Open[y][x] = '@';
				isGameOver = true;
				return;
			}
			int count = 0;
			int xT = 0;
			int yT = 0;
			if (x - 1 < 0) { xT = 1; }
			if (y - 1 < 0) { yT = 1; }

			for (int i = y - 1 + yT; i < y + 2 && i < seaBattle.Hidden.Count; i++) {
				for (int j = x - 1 + xT; j < x + 2 && j < seaBattle.Hidden[i].Count; j++) {
					if (seaBattle.Hidden[i][j] == 1) {
						count++;
					}
				}
			}
			seaBattle.Open[y][x] = count.ToString()[0];
		}
		public void getUserStep() {
			while (x <= 0 || x >= 50) { x = Alg.TryInt("Enter a 'X' for sapper game (>0 && <50) "); }
			while (y <= 0 || y >= 50) { y = Alg.TryInt("Enter a 'Y' for sapper game (>0 && <50) "); }
			x--;
			y--;
		}
		public void clearStep() {
			x = 0;
			y = 0;
		}
	}
}
