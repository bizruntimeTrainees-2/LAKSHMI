using System;
namespace Linq
{
    public class Program
    {
        delegate bool Student1(Student stud);

        public static void Main(string[] args)
        {
            Student1 std = delegate (Student s) { return s.Age > 25 && s.Age < 35; };

            Student stud = new Student() { Age = 28 };

            Console.WriteLine(std(stud));
            //delegates are used to return call back function

        }
    }

    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}