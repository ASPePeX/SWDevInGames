using System.Collections.Generic;
using ProtoBuf;

namespace StudentTypes
{
    [ProtoContract]
    public class Student
    {
        [ProtoMember(1)] public string FirstName;
        [ProtoMember(2)] public string LastName;
        [ProtoMember(3)] public string MatNumber;

        [ProtoMember(4)] public List<Course> CourseList;
    }

    [ProtoContract]
    public class Course
    {
        [ProtoMember(1)] public string Name;
        [ProtoMember(2)] public string Desc;
    }

    [ProtoContract]
    public class StudentRecord
    {
        [ProtoMember(1)] public List<Student> TheStudents;
    }
}
