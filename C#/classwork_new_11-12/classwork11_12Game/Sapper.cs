using System;
using static System.Console;
using static System.Collections.Generic.KeyValuePair;

using CommonTools;

namespace classwork7_8 {
	 public class Pair<T, U> {
		  public Pair() {
		  }

		  public Pair(T first, U second) {
				this.First = first;
				this.Second = second;
		  }

		  public T First { get; set; }
		  public U Second { get; set; }
	 };

	 public enum Direction {
		  Up,
		  Down,
		  Left,
		  Right
	 }

	 public enum TypeShip {
		  decker1,
		  decker2,
		  decker3,
	 }

	 public class ship {
		  public TypeShip typeShip;
		  public Direction direction;
		  public int length;

		  public ship() {
				this.typeShip = (TypeShip)Alg.RAND(0, Enum.GetValues(typeof(TypeShip)).Length - 1);
				direction = (Direction)Alg.RAND(0, Enum.GetValues(typeof(Direction)).Length - 1);
				length = 0;
				checkLen();
		  }

		  public ship(TypeShip typeShip) {
				this.typeShip = typeShip;
				direction = (Direction)Alg.RAND(0, Enum.GetValues(typeof(Direction)).Length - 1);
				length = 0;
				checkLen();
		  }

		  public void checkLen() {
				switch (typeShip) {
					 case TypeShip.decker1:
					 length = 1;
					 break;
					 case TypeShip.decker2:
					 length = 2;
					 break;
					 case TypeShip.decker3:
					 length = 3;
					 break;
				}
		  }
	 }
	 public class SeaBattle {
		  public const int shipsCnt = 6;

		  private List<List<int>> hiddenField;
		  private List<List<char>> openField;
		  private List<ship> ships;

		  public List<List<int>> Hidden { get => hiddenField; set => hiddenField = value; }
		  public List<List<char>> Open { get => openField; set => openField = value; }

		  private int height;
		  private int width;


		  public int Height { get => height; set => height = value; }
		  public int Width { get => width; set => width = value; }
		  public SeaBattle() {
				hiddenField = new List<List<int>>();
				openField = new List<List<char>>();
				ships = new List<ship>();
				height = 10;
				width = 10;
		  }
		  public SeaBattle(int Height, int Width) {
				ships = new List<ship>();
				hiddenField = new List<List<int>>();
				openField = new List<List<char>>();
				for (int i = 0; i < Height; i++) {
					 hiddenField.Add(new List<int>());
					 openField.Add(new List<char>());
				}
				height = Height;
				width = Width;
		  }
		  public void SetLists() {
				for (int i = 0; i < Height; i++) {
					 hiddenField.Add(new List<int>());
					 openField.Add(new List<char>());
				}
		  }
		  public void Fill() {
				    //pole = new Pole();
				    //ships = new List<BattleShip>();
				    for (int i = 0; i < 6; i++) {
					 ship temp = new ship();
					 while (!checkPos(temp)) {
						  temp = new ship();
					 }
					 ships.Add(temp);
					 pole.DrowShip(temp);

					 ships.Add(new ship(TypeShip.decker1));
					 ships.Add(new ship(TypeShip.decker1));
					 ships.Add(new ship(TypeShip.decker1));
					 ships.Add(new ship(TypeShip.decker2));
					 ships.Add(new ship(TypeShip.decker2));
					 ships.Add(new ship(TypeShip.decker3));

					 List<ship> shipsTemp = new List<ship>();
					 shipsTemp = ships;
					 int temp = 0;

					 for (int i = 0; i < height; i++) {
						  for (int j = 0; j < width; j++) {
								hiddenField[i].Add(temp);
								openField[i].Add('*');
						  }
					 }

					 Console.WriteLine("aaaa");
					 Pair<int, int> tuple = new Pair<int, int>();
					 Console.WriteLine("aaaa");


					 for (int i = 0; i < ships.Count; i++) {
						  //Console.WriteLine(i +")");


						  tuple = randPos(ships[i]);

						  //Console.WriteLine(i +")!");

						  //Console.WriteLine(0+")");
						  int Temp = 1;
						  int Temp2 = 0;
						  while (!checkPos(tuple, ships[i])) {

								Console.WriteLine($"Позиция для корабля {i + 1} не верна");

								//Console.WriteLine(i + ")");
								ships[i].direction = (Direction)(Temp - 1);
								if (Temp2 >= 30) {
									 Temp2 = 0;

								} else if (Temp == 4) {
									 tuple = randPos(ships[i]);
									 Temp = 0;
								}

								Temp++;
								Temp2++;
								//Console.WriteLine(tuple);
						  }
						  Console.WriteLine($"Позиция для корабля {i + 1} верна");


						  Console.WriteLine(ships[i].length);
						  Console.WriteLine(tuple.First + " " + tuple.Second);
						  setShip(tuple.First, tuple.Second, ships[i]);
					 }
					 Console.WriteLine(1);
				}

				public Pair<int, int> randPos() {

					 return new Pair<int, int>(Alg.RAND(0, 9), Alg.RAND(0, 9));
				}
				public Pair<int, int> randPos(ship ship) {
					 int dx = 0;
					 int dy = 0;
					 int LenLeftDeopazon = 0;
					 int LenRightDeopazon = 0;
					 switch (ship.direction) {
						  case Direction.Up:
						  dy = 1;
						  LenLeftDeopazon = dy * ship.length;
						  break;
						  case Direction.Down:
						  dy = -1;
						  LenRightDeopazon = dy * ship.length;
						  break;
						  case Direction.Left:
						  dx = 1;
						  LenLeftDeopazon = dx * ship.length;
						  break;
						  case Direction.Right:
						  dx = -1;
						  LenRightDeopazon = dx * ship.length;
						  break;
					 }

					 return new Pair<int, int>(Alg.RAND(0 + LenLeftDeopazon, 9 + LenRightDeopazon), Alg.RAND(0 + LenLeftDeopazon, 9 + LenRightDeopazon));
				}

				public bool checkPos(Pair<int, int> pos, ship ship) {
					 int dx = 0;
					 int dy = 0;
					 switch (ship.direction) {
						  case Direction.Up:
						  dy = -1;
						  break;
						  case Direction.Down:
						  dy = 1;
						  break;
						  case Direction.Left:
						  dx = -1;
						  break;
						  case Direction.Right:
						  dx = 1;
						  break;
					 }
					 Console.WriteLine($"dx={dx} dy={dy}");
					 Console.WriteLine($"Pair = {pos.First} {pos.Second}");
					 Console.WriteLine($"Dir = {ship.direction}");
					 int cnt = 0;
					 for (int i = pos.First, j = pos.Second; i < height - 1 && j < width - 1;) {
						  if (i + 1 >= height && cnt != ship.length) { return false; }
						  if (j + 1 >= width && cnt != ship.length) { return false; }
						  if (i - 1 <= 0 && cnt != ship.length) { return false; }
						  if (j - 1 <= 0 && cnt != ship.length) { return false; }
						  if (cnt == ship.length) { return true; }
						  if (hiddenField[i + 1][j] != 0) { return false; }
						  if (hiddenField[i][j + 1] != 0) { return false; }
						  if (i != 0) {
								if (hiddenField[i - 1][j] != 0) { return false; }

						  }
						  if (j != 0) {
								if (hiddenField[i][j - 1] != 0) { return false; }

						  }
						  i += dx;
						  j += dy;


						  cnt++;

						  Console.WriteLine($"i = {i} j = {j}");

					 }
					 return false;
				}

				public void setShip(int iT, int jT, ship ship) {
					 int dx = 0;
					 int dy = 0;

					 switch (ship.direction) {
						  case Direction.Up:
						  dy = -1;
						  break;
						  case Direction.Down:
						  dy = 1;
						  break;
						  case Direction.Left:
						  dx = -1;
						  break;
						  case Direction.Right:
						  dx = 1;
						  break;
					 }
					 int cnt = 0;
					 for (int i = iT; ;) {
						  for (int j = jT; ;) {
								if (cnt == ship.length) { return; }
								hiddenField[i][j] = ship.length;
								i += dx;
								j += dy;
								cnt++;
						  }
					 }
				}

				public void PrintOpen() {
					 for (int i = 0; i < height; i++) {
						  for (int j = 0; j < width; j++) {
								if (openField[i][j] == '@') {
									 Console.ForegroundColor = ConsoleColor.Red;
								} else if (openField[i][j] != '0' && openField[i][j] != '*') {
									 Console.ForegroundColor = ConsoleColor.Green;
								}
								Write("{0,4}", openField[i][j]);
								Console.ResetColor();
						  }
						  WriteLine();
					 }
				}
				public void PrintHidden() {
					 for (int i = 0; i < height; i++) {
						  for (int j = 0; j < width; j++) {
								Write("{0,4}", hiddenField[i][j]);
						  }
						  WriteLine();
					 }
				}

		  }

	 }
