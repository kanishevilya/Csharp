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
				#region
				//using (FileStream fstream = File.OpenRead(path)) {
				//	 // выделяем массив для считывания данных из файла
				//	 byte[] buffer = new byte[fstream.Length];
				//	 // считываем данные
				//	 fstream.ReadAsync(buffer, 0, buffer.Length);
				//	 // декодируем байты в строку
				//	 string textFromFile = Encoding.Default.GetString(buffer);
				//	 Console.WriteLine($"Текст из файла: {textFromFile}");
				//}
				//string pathToTxt = @"G:\Desktop\output.txt";
				//string textToWrite = "Hello World";

				//// полная перезапись файла 
				//using (StreamWriter writer = new StreamWriter(pathToTxt, false)) {
				//	 writer.WriteLineAsync(textToWrite);
				//}
				//// добавление в файл
				//using (StreamWriter writer = new StreamWriter(pathToTxt, true)) {
				//	 writer.WriteLineAsync("Addition");
				//	 writer.WriteAsync("4,5");
				//}

				//string pathToTxt2 = @"G:\Desktop\output.txt";
				//// асинхронное чтение
				//using (StreamReader reader = new StreamReader(pathToTxt2)) {
				//	 string textFromFile = reader.ReadToEnd();
				//	 Console.WriteLine(text);
				//}
				//using (StreamReader reader = new StreamReader(pathToTxt2)) {
				//	 string? line;
				//	 while ((line = reader.ReadLine()) != null) {
				//		  Console.WriteLine(line);
				//	 }
				//}
				//return;

				//for (int i = 0; i < 3; i++) {
				//	 using (FileStream fstream = new FileStream(path+i.ToString(), FileMode.OpenOrCreate)) {
				//		  byte[] buffer = Encoding.Default.GetBytes(text);
				//		  fstream.WriteAsync(buffer, 0, buffer.Length);
				//		  Console.WriteLine("File записан");

				//		  //fstream.Close();
				//	 }
				//}

				//return;
				////getCatalog("D:\\", 3);
				////return;
				//string dirName = "C:\\";
				#endregion
				Console.WriteLine("Enter a path to Catalog: ");
				string path = ReadLine();
				string[] filesAndFolders = Directory.GetFiles(path);
				var searchResult = filesAndFolders.Where(x => x.Contains(".exe")).OrderByDescending(x => x).Select(x=>x);
				foreach (var item in searchResult) {
					 Console.WriteLine(item);
				}
				return;
				int[] arrayInt=new int[7];
				Alg.RandFillArray(arrayInt, -10, 10);

				IEnumerable<int> query = from i in arrayInt
												 where i % 2 == 0
												 orderby i descending
												 select i;
				foreach(int i in query) {
					 Console.WriteLine(i);
				}
				return;
				bool isEnd = false;
				//while (!isEnd) {
				//	 Console.WriteLine("Enter a path to Catalog: ");
				//	 string path = ReadLine();
				//	 string extens;
				//	 List<string> filesNames = new List<string>();
				//	 filesNames.Clear();
				//	 Console.WriteLine($"Files from catalog {path}: ");
				//	 if (Directory.Exists(path)) {
				//		  string[] files = Directory.GetFiles(path);
				//				Console.WriteLine();
				//		  foreach(string file in files) {
				//				Console.WriteLine(file);
				//				Console.WriteLine();
				//		  }

				//		  Console.WriteLine("Enter an extension for files (without dot): ");
				//		  extens = ReadLine();

				//		  FileInfo fileInfo;
				//		  for (int i = 0; i < files.Length; i++) {
				//				fileInfo = new FileInfo(files[i]);
				//				if (fileInfo.Extension.ToLower() == ("."+extens)) { filesNames.Add(files[i]); }
				//		  }
				//		  filesNames.Sort();
				//		  foreach (string file in filesNames) {
				//				Console.WriteLine(file);
				//		  }
				//		  isEnd = true;
				//	 } else {
				//		  Console.WriteLine("Error path!");
				//	 }
				//}

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
