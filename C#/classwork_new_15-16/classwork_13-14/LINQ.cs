using System;
using System.Linq;
using static System.Console;

namespace classwork15_16 {
	 public class LINQ {
		  public static void MainLINQ() {
				int[] numbers = { 2, 4, 3, 2, 4, 6, 7, 2, 3, 5, 9, 10, 11 };

				Console.WriteLine($"Amount: {numbers.Count()}");

				var result = numbers.Where(x => x % 2 == 0).Distinct().Skip(2).Take(2);
				foreach (var i in result)
					 WriteLine(i);
		  }
	 }
}
