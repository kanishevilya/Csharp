using System;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject {
	 public delegate void ExamDelegate(string t);

	 class Student {
		  public string FirstName { get; set; }
		  public string LastName { get; set; }
		  public DateTime BirthDate { get; set; }

		  public void Exam(string task) {
				WriteLine($"Student {LastName} solved the {task}");
		  }
	 }

	 class Teacher {
		  public event ExamDelegate examEvent;

		  public void Exam(string task) {
				if (examEvent != null) {
					 examEvent(task);
				}
		  }
		  public int ExamStList() {
				if (examEvent != null) {
					 return examEvent.GetInvocationList().Length;
				}
				return 0;
		  }
	 }

	 public static class Program {
		  static void Main(string[] args) {
				List<Student> group = new List<Student> {
            new Student {
            FirstName = "John",
            LastName = "Miller",
            BirthDate = new DateTime(1997,3,12)
            },
            new Student {
            FirstName = "Candice",
            LastName = "Leman",
            BirthDate = new DateTime(1998,7,22)
            },
            new Student {
            FirstName = "Joey",
            LastName = "Finch",
            BirthDate = new DateTime(1996,11,30)},
            new Student {
            FirstName = "Nicole",
            LastName = "Taylor",
            BirthDate = new DateTime(1996,5,10)}
            };

				Teacher teacher = new Teacher();

				foreach (Student student in group) {
					 teacher.examEvent += student.Exam;
				}
				teacher.examEvent += delegate (string t){
					 WriteLine("Exam tasks qued");
				};
				teacher.Exam("Task");

			  Console.WriteLine(teacher.ExamStList());
		  }
	 }
}