using System;
using static System.Console;

using CommonTools;
namespace classwork7_8 {
	 public class Program {

		  //Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий
		  //стран на русском и английском языках.Пользователь
		  //должен иметь возможность выбирать направление перевода и запрашивать перевод
		  //Словарь может быть преднаполненным или справшивать у пользователя.
		  //В нагрузку, сделайте словарь разных языков KZ, RU, EN, FR, IT, JP
		  public enum Language {
				Russian,
				Kazakh,
				English,
				French
		  }
		  public class Word {
				public Language language { get; set; }
				public string Name { get; set; }

				public Word(Language language, string name) {
					 this.language = language;
					 this.Name = name;
				}
		  }
		  public class Dictionary {
				private List<List<Word>> dictionary;

				public Dictionary() {
					 dictionary = new List<List<Word>>();

					 for (int i = 0; i < typeof(Language).GetEnumValues().Length; i++) {
						  dictionary.Add(new List<Word>());
					 }
				}
				public void AddWord() {
					 string temp;
					 for (int i = 0; i < typeof(Language).GetEnumValues().Length; i++) {
						  Console.WriteLine($"Введите слово на языке: {(Language)i}");
						  temp = ReadLine();
						  dictionary[i].Add(new Word((Language)i, temp));
					 }
				}
				public void PrintAll() {
					 for (int i = 0; i < typeof(Language).GetEnumValues().Length; i++) {
						  WriteLine($"Язык: {(Language)i}");
						  for (int j = 0; j < dictionary[i].Count; j++) {
								WriteLine($"{j + 1}) {dictionary[i][j].Name}");
						  }
					 }
				}
				public void PrintOneLanguageList(int idx) {
					 Console.WriteLine($"Language: {(Language)idx}");
					 for (int i = 0; i < dictionary[idx].Count; i++) {
						  Console.WriteLine($"{i + 1}) {dictionary[idx][i].Name}");
					 }
				}
				public void PrintOneWordFromAllLanguages(int idx) {
					 Console.WriteLine($"Одно слово на всех языках");
					 for (int i = 0; i < dictionary.Count; i++) {
						  Console.WriteLine($"{i + 1}) {dictionary[i][idx].Name}");
					 }
				}
				public void PrintTranslate(int idx, Language first, Language second) {
					 Console.WriteLine($"Перевод слова {dictionary[(int)first][idx].Name} с {first} на {second}: {dictionary[(int)second][idx].Name}");
				}

				public void AddFew(int cnt) {
					 for (int i = 0; i < cnt; i++) {
						  AddWord();
					 }
				}
				public void Start() {
					 Console.WriteLine("Введите начальное кол-во слов: ");
					 int cnt = 0;
					 while(cnt <= 0) { cnt = Alg.TryInt("(>0)"); }
					 AddFew(cnt);
					 bool isExit = false;
					 int key = -1;
					 while (!isExit) {
						  while (key < 0 || key > 5) { key = Alg.TryInt("Enter a key:\n1.Перевод слова\n2.Вывод всех слов\n3.Вывод определенного слова всех языков\n4.Вывод слов одного языка\n5.Добавить слово\n0.Выход"); }
						  switch (key) {
								case 0:
								isExit = true;
								break;
								case 1: 
							   {
									 int keyLangFrst = -1;
									 int keyLangSec = -1;
									 Console.WriteLine("Enter a Language:");
									 for (int i = 0; i < typeof(Language).GetEnumValues().Length; i++) {
										  Console.WriteLine($"{i + 1}) {(Language)i}");
									 }
									 while (keyLangFrst < 0 || keyLangFrst > typeof(Language).GetEnumValues().Length - 1) { keyLangFrst = Alg.TryInt("First"); }
									 while (keyLangSec < 0 || keyLangSec > typeof(Language).GetEnumValues().Length - 1) { keyLangSec = Alg.TryInt("Second"); }
									 int idx = 0;
									 while (idx <= 0 || idx > dictionary[0].Count) { idx = Alg.TryInt($"Enter a idx for translate [max({dictionary[0].Count})]"); }
									 PrintTranslate(idx-1, (Language)keyLangFrst-1, (Language)keyLangSec-1);
								}
								break;
								case 2:
								PrintAll();
								break;
								case 3: 
							   {
									 int idx = 0;
									 while (idx <= 0 || idx > dictionary[0].Count) { idx = Alg.TryInt($"Enter a idx [max({dictionary[0].Count})]"); }
									 PrintOneWordFromAllLanguages(idx-1);
								}
								break;
								case 4: 
								{
									 int keyLang = -1;
									 Console.WriteLine("Enter a Language:");
									 for (int i = 0; i < typeof(Language).GetEnumValues().Length; i++) {
										  Console.WriteLine($"{i + 1}) {(Language)i}");
									 }
									 while (keyLang < 0 || keyLang > typeof(Language).GetEnumValues().Length - 1) { keyLang = Alg.TryInt(); }
									 PrintOneLanguageList(keyLang-1);
								}
								break;
								case 5: 
								{
									 AddWord();
								}
								break;
						  }
						  key = -1;
					 }
				}
		  }

		  static void Main(string[] args) {

				Dictionary dictionary = new Dictionary();
				dictionary.Start();
		  }
	 }
}
