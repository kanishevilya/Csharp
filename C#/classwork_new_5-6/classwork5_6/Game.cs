using System;
using static System.Console;

using CommonTools;

namespace classwork5_6 {
	public class Game {
		private Deck player;
		private Deck enemy;
		private Color trump;
		private int PlayerScore;
		private int EnemyScore;
		public Game() {
			player = new Deck();
			enemy = new Deck();
			trump = Color.Diamonds;
			PlayerScore = 0;
			EnemyScore = 0;
		}
		public void Start(){
			randTrump();
			player.Settings();
			enemy.Settings();
			WriteLine($"Trump is {trump}\n");
			while (player._Deck.Count != 0 && enemy._Deck.Count != 0) {

				WriteLine("Player card: " + player._Deck[0]);
				WriteLine("Enemy card: " + enemy._Deck[0]);
				checkScore();
				WriteLine($"Player score: {PlayerScore}");
				WriteLine($"Enemy score: {EnemyScore}");
				player._Deck.RemoveAt(0);
				enemy._Deck.RemoveAt(0);
				Read();
				Read();
			}

			if (PlayerScore > EnemyScore) {
				WriteLine("Player win!");
			} else if (EnemyScore > PlayerScore) {
				WriteLine("Enemy win!");
			}else{
				WriteLine("Draw!");
			}
		}
		private void checkScore(){
			if (player._Deck[0] > enemy._Deck[0] == 1) {
				PlayerScore++;
			} else if (player._Deck[0] > enemy._Deck[0] == 0) {
				EnemyScore++;
			} else {
				PlayerScore++;
				EnemyScore++;
			}
		}
		private void randTrump(){
			trump = (Color)Alg.RAND(0, Enum.GetNames(typeof(Color)).Length - 1);
			player.Trump = trump;
			enemy.Trump = trump;
		}
	}
}
