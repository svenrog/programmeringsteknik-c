using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public struct Student
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    List<Student> listOfStudentOjects = new List<Student>();
    public void Add(string student, int grade)
    {
        listOfStudentOjects.Add(new Student(student, grade));
    }
    public IEnumerable<string> Roster()
    {
        List<string> sortetListOfStudentNames = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            List<string> listOfStudentsInGrade = new List<string>();
            var filteredListOfStudentOjects = listOfStudentOjects.FindAll(delegate (Student student)
            {
                return student.Grade == i;
            });
            foreach (Student studentObject in filteredListOfStudentOjects)
            {
                listOfStudentsInGrade.Add(studentObject.Name);
            }
            listOfStudentsInGrade.Sort();
            foreach (string studentName in listOfStudentsInGrade)
            {
                sortetListOfStudentNames.Add(studentName);
            }
        }
        return sortetListOfStudentNames;
    }

    public IEnumerable<string> Grade(int grade)
    {
        {
            var filteredListOfStudentOjects = listOfStudentOjects.FindAll(delegate (Student studentObject)
            {
                return studentObject.Grade == grade;
            });
            List<string> students = new List<string>();
            foreach (Student studentObject in filteredListOfStudentOjects)
            {
                students.Add(studentObject.Name);
            }
            students.Sort();
            return students;
        }
    }
}