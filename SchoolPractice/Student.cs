using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        private int numberOfCredits;
        private double gpa;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalQualityScore = (Gpa * NumberOfCredits); 
            NumberOfCredits += courseCredits;

            totalQualityScore += (courseCredits * grade); 
            Gpa = totalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits <= 29)
            {
                return "Grade level: Freshman.";
            }
            else if (credits >= 30 && credits <= 59)
            {
                return "Grade level: Sophomore.";
            }
            else if (credits >= 60 && credits <=89)
            {
                return "Grade level: Junior."; 
            }
            else if (credits >= 90)
            {
                return "Grade level: Senior.";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.


    }
}
