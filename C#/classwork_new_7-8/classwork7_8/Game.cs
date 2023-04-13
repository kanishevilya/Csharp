using System;
using static System.Console;

using CommonTools;

namespace classwork7_8 {
	public class Game {
		private int x, y;
		private Sapper sapper;

		bool isGameOver;
		public Game() {
			sapper = new Sapper();
			x = 0;
			y = 0;
		}
		public void Start() {
			sapper.Width = 0;
			sapper.Height = 0;
			sapper.Complexity = 0;

			while (sapper.Width <= 0 || sapper.Width>50){ sapper.Width = Alg.TryInt("Enter a field width (>0 <=50)"); }
			while (sapper.Height <= 0 || sapper.Height > 50){ sapper.Height = Alg.TryInt("Enter a field Height (>0 <=50)"); }
			while (sapper.Complexity <= 0 || sapper.Complexity > 4){ sapper.Complexity = Alg.TryInt("Enter a complexity (>0 <4)"); }
			sapper.SetLists();
			sapper.Fill();


			while (!isGameOver) {
				sapper.PrintHidden();
				Console.WriteLine();
				sapper.PrintOpen();
				Console.WriteLine();

				getUserStep();

				checkStep();

				clearStep();
				Console.Clear();
			}

			sapper.PrintOpen();
			x = 0;
			y = 0;
			isGameOver = false;
			Console.WriteLine("Game Over!!");
		}

		public void checkStep() {

			if (sapper.Hidden[y][x] == 1){
			  
				sapper.Open[y][x] = '@';
				isGameOver = true;
				return;
			}
			int count = 0;
			int xT = 0;
			int yT = 0;
			if(x-1<0){ xT=1; }
			if(y-1<0){ yT=1; }

			for (int i = y - 1 +yT; i < y + 2 && i<sapper.Hidden.Count; i++) {
				for (int j = x - 1+xT; j < x + 2 && j < sapper.Hidden[i].Count; j++) {
					if (sapper.Hidden[i][j] == 1) {
						count++;
					}
				}
			}
			sapper.Open[y][x] = count.ToString()[0];
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
