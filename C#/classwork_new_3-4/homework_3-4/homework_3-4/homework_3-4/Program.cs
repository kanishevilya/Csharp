using System;
using static System.Console;
using CommonTools;

namespace homework_3_4;

public class Program{
  public static void Main(string[] args){
    int num = 1;  //число для вывода
    int row = 0;  
    int col = 0;
		Console.WriteLine("P.S. Сделайте буффер консоли побольше, ибо из-за переноса могут быть проблемы");
    while (row <= 0 || row >100) { row = Alg.TryInt("Enter a rows count (>0 && <=100): "); }
    while (col <= 0 || col > 100) { col = Alg.TryInt("Enter a cols count (>0 && <=100): "); }
    int numIfSnakeNotCurved = row + col - 1; //не замкнутое место сгиба с соседним элементом имеет такое соотношение  (1 8 => 8=1+4+4-1) прибав в row+col-1; далее -=2  (1 8, 2 7, 3 6, 4 5) и тд.
    int numIfSnakeCurved = 1; //место сгиба в начале прибав идет в +1, далее на 2 больше
    bool isCurved = false;
		for (int i = 0, j=0; i < row; i++) {
      num = i + 1;
			for (j = 0; j < col; j++) {
        Write("{0, 7}",$" {num} "); 
        if(isCurved){  //Узлы змейки соседние, поэтому он будет замкнута или не замкнута в момент.
          num += numIfSnakeCurved;
          isCurved = false;
        }else{
          num += numIfSnakeNotCurved;
          isCurved = true;
				}
			}
      isCurved = false;
      numIfSnakeNotCurved -= 2;
      numIfSnakeCurved += 2;
			Console.WriteLine();
		}
  }
  
  
}