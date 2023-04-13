using System;
using System.IO;
using System.Text;
using static System.Console;

using CommonTools;
namespace classwork9_10 {
	 public class Program {


		  public static void Main(string[] args) {
				//DriveInfo[] drives = DriveInfo.GetDrives();
				//foreach (DriveInfo drive in drives) {
				//	 Console.WriteLine($"Название: {drive.Name}");
				//	 Console.WriteLine($"Тип: {drive.DriveType}");
				//	 if (drive.IsReady) {
				//		  Console.WriteLine($"Объем: {drive.TotalSize}");
				//		  Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
				//		  Console.WriteLine($"Свободно: {(float)drive.TotalFreeSpace}");
				//		  Console.WriteLine($"Том: {drive.VolumeLabel}");
				//	 }
				//}
				//getCatalog("D:\\", 10);
				string path = @"D:\Games\output.txt";
				string text = "Hello Ilya";
				using (FileStream fstream = File.OpenRead(path)) {
					 // выделяем массив для считывания данных из файла
					 byte[] buffer = new byte[fstream.Length];
					 // считываем данные
					 fstream.ReadAsync(buffer, 0, buffer.Length);
					 // декодируем байты в строку
					 string textFromFile = Encoding.Default.GetString(buffer);
					 Console.WriteLine($"Текст из файла: {textFromFile}");
				}
				string pathToTxt = @"G:\Desktop\output.txt";
				string textToWrite = "Hello World";

				// полная перезапись файла 
				using (StreamWriter writer = new StreamWriter(pathToTxt, false)) {
					 writer.WriteLineAsync(textToWrite);
				}
				// добавление в файл
				using (StreamWriter writer = new StreamWriter(pathToTxt, true)) {
					 writer.WriteLineAsync("Addition");
					 writer.WriteAsync("4,5");
				}

				string pathToTxt2 = @"G:\Desktop\output.txt";
				// асинхронное чтение
				using (StreamReader reader = new StreamReader(pathToTxt2)) {
					 string textFromFile = reader.ReadToEnd();
					 Console.WriteLine(text);
				}
				using (StreamReader reader = new StreamReader(pathToTxt2)) {
					 string? line;
					 while ((line = reader.ReadLine()) != null) {
						  Console.WriteLine(line);
					 }
				}
				return;

				for (int i = 0; i < 3; i++) {
					 using (FileStream fstream = new FileStream(path+i.ToString(), FileMode.OpenOrCreate)) {
						  byte[] buffer = Encoding.Default.GetBytes(text);
						  fstream.WriteAsync(buffer, 0, buffer.Length);
						  Console.WriteLine("File записан");

						  //fstream.Close();
					 }
				}

				return;
				//getCatalog("D:\\", 3);
				//return;
				string dirName = "C:\\";

				if (Directory.Exists(dirName)) {
					 Console.WriteLine("Подкаталоги");
					 string[] dirs = Directory.GetDirectories(dirName);
					 foreach (string dir in dirs) {
						  Console.WriteLine(dir);
					 }
					 Console.WriteLine();
					 Console.WriteLine("Files: ");
					 string[] files = Directory.GetFiles(dirName);
					 foreach (string file in files) {
						  Console.WriteLine(file);
					 }
				}

		  }

		  static public void getCatalog(string dirName, int maxDepth, int currentDepth = 0) {
				if (Directory.Exists(dirName)) {
					 if (currentDepth >= maxDepth
						  || dirName.Contains("System Volume Information")
						  || dirName.Contains("$")) {
						  return;
					 }
					 foreach (var directory in Directory.GetDirectories(dirName)) {
						  Console.WriteLine(directory);
						  getCatalog(directory, maxDepth, currentDepth + 1);
					 }
				}
		  }

	 }
}
