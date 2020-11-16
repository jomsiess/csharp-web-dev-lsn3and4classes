using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public List<Student> Students {get; set;}
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public Course(List<Student>students, string courseName, int credits)
        {
            Students = students;
            CourseName = courseName;
            Credits = credits; 
        }
    }
}
