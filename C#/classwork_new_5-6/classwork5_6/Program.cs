using System;
using static System.Console;

using CommonTools;
namespace classwork5_6 {
	public class Program {
		static void Main(string[] args) {
		   Game game = new Game();
			bool isExists = true;
			while (isExists) {
				game.Start();
				WriteLine("1 to restart\nElse to Exit");
				int key = Alg.TryInt();
				if (key == 1) {
					game.Start();
				}else{
					isExists = false;
					return;
				}
			}
		}
	}
}
