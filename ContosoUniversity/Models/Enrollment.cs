using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // This is a many-to-many join table with payload between the Student and Course entities.
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } // FK in the form of <PK property name>
        public int StudentID { get; set; } // FK in the form of <navigation property name><PK property name>
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; } // Both this and Student are called navigation properties
        public Student Student { get; set; }
    }
}
