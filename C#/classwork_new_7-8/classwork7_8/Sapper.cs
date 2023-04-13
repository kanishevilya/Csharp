using System;
using static System.Console;

using CommonTools;

namespace classwork7_8 {

	public class Sapper {
		private List<List<int>> hiddenField;
		private List<List<char>> openField;

		public List<List<int>> Hidden{ get => hiddenField; set => hiddenField = value; }
		public List<List<char>> Open{ get => openField; set => openField = value; }

		private int height;
		private int width;

		private int complexity;

		public int Height{ get => height; set => height = value; }
		public int Width{ get => width; set => width = value; }
		public int Complexity{ get => complexity; set => complexity = value; }
		public Sapper() {
			hiddenField=new List<List<int>>();
			openField=new List<List<char>>();
			height = 0;
			width = 0;
			complexity = 1;
		}
		public Sapper(int Height, int Width, int Complexity) {
			hiddenField = new List<List<int>>();
			openField = new List<List<char>>();
			for (int i = 0; i < Height; i++) {
				hiddenField.Add(new List<int>());
				openField.Add(new List<char>());
			}
			height = Height;
			width = Width;
			complexity = Complexity;
		}
		public void SetLists(){
			for (int i = 0; i < Height; i++) {
				hiddenField.Add(new List<int>());
				openField.Add(new List<char>());
			}
		}
		public void Fill(){
			int temp = 0;
			for (int i = 0; i < height; i++) {
				for (int j = 0; j < width; j++) {
				   
				   if(Alg.RAND(0, complexity)!=0){
						  temp = 0;
					 }else{
						  temp = 1;
					 }
					 hiddenField[i].Add(temp);
					 openField[i].Add('*');
				}
			}
		}

		public void PrintOpen(){
			for (int i = 0; i < height; i++) {
				for (int j = 0; j < width; j++) {
				    if(openField[i][j]=='@'){	       
						  Console.ForegroundColor = ConsoleColor.Red;
						}
			      else if(openField[i][j]!='0' && openField[i][j] != '*') {
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
