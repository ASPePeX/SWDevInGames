using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using StudentTypes;

namespace StudentDataWriter
{

    class Program
    {
        static void Main(string[] args)
        {
            StudentRecord theStudents = new StudentRecord();
            theStudents.TheStudents = new List<Student>();

            for (;;)
            {
                Console.WriteLine("Enter new student. \"exit\" to cancel");
                var studi = new Student();
                Console.Write("First Name: ");
                studi.FirstName = Console.ReadLine();
                if (studi.FirstName == "exit")
                    break;
                Console.Write("Last Name: ");
                studi.LastName = Console.ReadLine();
                Console.Write("Mat Number: ");
                studi.MatNumber = Console.ReadLine();

                studi.CourseList = new List<Course>();
                for (; ; )
                {
                    Console.WriteLine("Enter new course for " + studi.FirstName + " " + studi.LastName + " or \"exit\" to cancel");
                    Course course = new Course();
                    Console.Write("Course Name: ");
                    course.Name = Console.ReadLine();
                    if (course.Name == "exit")
                        break;
                    Console.Write("Course Description: ");
                    course.Desc = Console.ReadLine();
                    studi.CourseList.Add(course);
                }

                theStudents.TheStudents.Add(studi);
            }

            // Write the students 
            var studentSerializer = new StudentSerializer();
            studentSerializer.Serialize(new FileStream("Data.students", FileMode.Create), theStudents);
        }
    }
}
