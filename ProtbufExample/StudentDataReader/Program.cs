using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Xml;
using StudentTypes;

namespace StudentDataReader
{

    class Program
    {
        static void Main(string[] args)
        {
            // Read the students 
            StudentRecord theStudents;
            var studentSerializer = new StudentSerializer();
            theStudents = (StudentRecord) studentSerializer.Deserialize(new FileStream("Data.students", FileMode.Open), null, typeof(StudentRecord));

            foreach (var student in theStudents.TheStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "(" + student.MatNumber + ") is enrolled in");
                foreach (var course in student.CourseList)
                {
                    Console.WriteLine(course.Name + ": " + course.Desc);
                }
            }

            Console.ReadKey();
        }
    }
}
