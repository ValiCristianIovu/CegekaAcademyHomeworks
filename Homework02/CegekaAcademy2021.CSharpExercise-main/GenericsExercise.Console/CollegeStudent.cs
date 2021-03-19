using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{
    public class CollegeStudent<Student,University>:IEntity
    {
        public string Id { get; set; }
        public Student stud { get; set; }
        public University uni { get; set; }

        public  CollegeStudent(string id,Student student,University university)
        {
            Id = id;
            stud = student;
            uni = university;

        }
    }
}
