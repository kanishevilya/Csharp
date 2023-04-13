using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using methods;

namespace homework_5_6
{
    //Придумать класс, описывающий студента Предусмотреть в нем следующие моменты: фамилия, имя,
    //отчество, группа, возраст, массив(зубчатый) оценок по
    //программированию, администрированию и дизайну
    //А также добавить методы по работе с перечисленными данными:
    //возможность установки/получения оценки, получение среднего балла по заданному предмету,
    //распечатка данных о студенте
    public class Student
    {
        private string firstName; //Имя
        private string secondName; //Фамилия
        private string surName; //Очество
        private string group; //Группа
        private int age; //Возраст
        private int[][] grades; //оценки


    
        public Student()
        {
            this.firstName = string.Empty;
            this.secondName = string.Empty;
            this.surName = string.Empty;
            this.group = string.Empty;
            this.age = 0;
            this.grades = new int[3][];
        }
        public Student(string firstName, string secondName, string surName, string group, int age, int[][] grades)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.surName = surName;
            this.group = group;
            this.age = age;
            this.grades = grades;
        }

        public string FirstName{get=>firstName; private set => firstName=value; }
        public string SecondName { get => secondName; private set => secondName = value; }
        public string SurName { get => surName; private set => surName = value; }
        public string Group { get => group; private set => group = value; }
        public int Age { get => age; private set => age = value; }
        public int[][] Grades { get => grades; private set => grades = value; }

        public void setAllGradesArraySize(int size)
        {
            for (int i = 0; i < grades.Length; ++i)
            {
                Array.Resize(ref grades[i], size);
            }
        }
        public void setGradesSize(int idxTypeGrades, int size)
        {
            Array.Resize(ref grades[idxTypeGrades], size);
        }
        public void setGradesSize(ref int[] grade, int size)
        {
            Array.Resize(ref grade, size);
        }

        public void randFillGradesSingle(ref int[] grade)
        {
            for (int i = 0; i < grade.Length; i++)
            {
                grade[i] = alg.RAND(1, 12);
            }
        }
        public void randFillGradesSingle(int idxTypeGrades)
        {
            for (int i = 0; i < grades[idxTypeGrades].Length; i++)
            {
                grades[idxTypeGrades][i] = alg.RAND(1, 12);
            }
        }
        public void randFillGradesForAll()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                randFillGradesSingle(ref grades[i]);
            }
        }

        public float averageGrade(int idxTypeGrades)
        {
            return (float)grades[idxTypeGrades].Average();
        }

        public void initStudent()
        {
            firstName = alg.randString(8);
            secondName = alg.randString(10);
            surName = alg.randString(11);
            group = ((Groups)alg.RAND(0, Enum.GetValues(typeof(Groups)).Length - 1)).ToString();
            age = alg.RAND(15, 29);
            setAllGradesArraySize(alg.RAND(3,8));
            randFillGradesForAll();
        }

        public void Print()
        {
            Console.WriteLine($"FirstName : {firstName}");
            Console.WriteLine($"SecondName: {secondName}");
            Console.WriteLine($"SurName   : {surName}");
            Console.WriteLine($"Group     : {group}");
            Console.WriteLine($"Age       : {age}");
            Console.WriteLine("Grades     : ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"{i+1}) "+((Discipline)i).ToString());
                for (int j = 0; j < grades[i].Length; j++)
                {
                    Console.Write(grades[i][j] +" ");
                }
                Console.WriteLine();
            }
        }

        
    }
    enum Discipline
    {
        Programming,
        Administration,
        Design
    }
    enum Groups
    {
        SDP221_1,
        SDE222_2,
        SDP222_1,
        SET11_M,
        DESIGN192_DL
    }
}
