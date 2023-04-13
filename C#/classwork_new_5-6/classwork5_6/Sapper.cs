using System;
using static System.Console;

using CommonTools;

namespace classwork5_6 {
	public enum Color {
		Diamonds,
		Hearts,
		Clubs,
		Spades
	}
	public class Card {
		public int Number;
		public Color Color;
		public bool isTrump;

		public Card() {
			Number = 0;
			Color = Color.Diamonds;
			isTrump = false;
		}
		public Card(Card crd){
			Number = crd.Number;
			Color = crd.Color;
			isTrump = crd.isTrump;
		}
		public Card(int Number, Color color, bool isTrump) {
			this.Number = Number;
			this.Color = color;
			this.isTrump = isTrump;
		}

		public static int operator >(Card lhs, Card rhs) {
			int temp;
			if (lhs.isTrump == true && rhs.isTrump == false) {
				return 1;
			} else if (lhs.isTrump == false && rhs.isTrump == true) {
				return 0;
			} else {
				if (lhs.Number > rhs.Number) {
					temp = 1;
				} else if (lhs.Number < rhs.Number) {
					temp = 0;
				} else {
					temp = 2;
				}
				if (lhs.Number == 2 && rhs.Number == 14) {
					temp = 1;
				}
			}
			return temp;
		}
		public static int operator <(Card lhs, Card rhs) {
			if (lhs > rhs == 1) {
				return 0;
			} else if (lhs > rhs == 0) {
				return 1;
			} else {
				return 2;
			}
		}
		public override string ToString() {
			string temp = "";
			switch (Number) {
				case 2: temp = "2"; break;
				case 3: temp = "3"; break;
				case 4: temp = "4"; break;
				case 5: temp = "5"; break;
				case 6: temp = "6"; break;
				case 7: temp = "7"; break;
				case 8: temp = "8"; break;
				case 9: temp = "9"; break;
				case 10: temp = "10"; break;
				case 11: temp = "J"; break;
				case 12: temp = "Q"; break;
				case 13: temp = "K"; break;
				case 14: temp = "A"; break;
			}
			string card = $"Number = {temp} | Suit = {Enum.GetName(typeof(Color), Color)} | IsTrump = {isTrump}";
			return card;
		}
	}
	public class Deck {
		private List<Card> _deck; 
	  private Color trump;
		public List<Card> _Deck { get=>_deck; set=>_deck=value; }
		public Color Trump { get => trump; set => trump = value; }

		public Deck() {
			_deck = new List<Card>();
			trump = Color.Diamonds;
		}
		public Deck(Color trump) {
			_deck = new List<Card>();
			this.trump = trump;
		}
		private void Fill() {
			for (int i = 0; i < 4; i++) {
				for (int j = 2; j <= 14; j++) {
					if (i == 0) {
						_deck.Add(new Card(j, Color.Diamonds, trump == Color.Diamonds));
					} else if (i == 1) {
						_deck.Add(new Card(j, Color.Hearts, trump == Color.Hearts));
					} else if (i == 2) {
						_deck.Add(new Card(j, Color.Clubs, trump == Color.Clubs));
					} else if (i == 3) {
						_deck.Add(new Card(j, Color.Spades, trump == Color.Spades));
					}
				}
			}
		}
		public void randChange() {
			int tempIdx;
			for (int i = 0; i < _deck.Count; i++) {
				tempIdx = Alg.RAND(0, _deck.Count - 1);
				Swap(i, tempIdx);
			}
		}
		public void Settings(){
			Fill();
			randChange();
		}
		private void Swap(int idx1, int idx2){
			Card temp = _deck[idx1];
			_deck[idx1] = _deck[idx2];
			_deck[idx2] = temp;
		}
	}
}
