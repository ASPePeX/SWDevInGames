using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTypes;


namespace ProtobufTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentliste = new StudentList();
            studentliste.students = new List<Student>();

            var student = new Student();
            student.firstname = "Hans";
            student.lastname = "Blab";
            student.matnr = "124123";

            student.courses = new List<Course>();

            var mycourse = new Course();
            mycourse.name = "Gamestuff";
            mycourse.desc = "Stuff with Games";

            student.courses.Add(mycourse);
            studentliste.students.Add(student);

        }
    }
}
