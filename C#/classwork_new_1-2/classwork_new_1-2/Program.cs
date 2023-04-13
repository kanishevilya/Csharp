using System;
using static System.Console;

namespace classwork_new_1_2 {
  class Program {
    public static void Main(string[] args) {
      int a=0, b=0;
			WriteLine("Enter a first value: ");
      a = int.Parse(ReadLine());
      WriteLine("Enter a second value: ");
      b = int.Parse(ReadLine());
      ForegroundColor = ConsoleColor.Green;
      WriteLine($"Sum = {a+b}");
      ForegroundColor = ConsoleColor.Cyan;
      WriteLine($"Comp = {a*b}");
      ForegroundColor = ConsoleColor.Red;
      WriteLine($"Pow (a^b) = {Math.Pow(a,b)}");
      ResetColor();

      string n = "421";
      ref string m = ref n;


    }
  }
}