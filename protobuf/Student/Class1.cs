using System.Collections.Generic;
using ProtoBuf;

namespace StudentTypes
{
    [ProtoContract]
    public class Student
    {
        [ProtoMember(1)]
        public string firstname;
        [ProtoMember(2)]
        public string lastname;
        [ProtoMember(3)]
        public string matnr;

        [ProtoMember(4)]
        public List<Course> courses;
    }

    [ProtoContract]
    public class Course
    {
        [ProtoMember(1)]
        public string name;
        [ProtoMember(2)]
        public string desc;
    }

    [ProtoContract]
    public class StudentList
    {
        [ProtoMember(1)]
        public List<Student> students;
    }

}
