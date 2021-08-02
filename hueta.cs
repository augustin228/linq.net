using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
             IList<Student> studentList = new List<Student>(){
               new Student() { StudentId = 1, StudentName = "test3", Age = 21 },
               new Student() { StudentId = 2, StudentName = "test2", Age = 20 },
               new Student() { StudentId = 3, StudentName = "test1", Age = 21 }
            };

            var groupAlStuds = from s in studentList group s by s.Age;


            foreach (var ageGroup in groupAlStuds){
                Console.WriteLine("услованя группирввка студентов по имени", ageGroup.Key);

                foreach (Student s in ageGroup) Console.WriteLine(s.StudentName);
            }
        }
    }

    public class Student{
        public int StudentId {get; set;}
        public string StudentName {get; set;}
        public int Age {get; set;}
    }
}