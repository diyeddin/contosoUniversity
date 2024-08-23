using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; } // PK can be just ID or StudentID
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; } // Create page wasnt working because of this. It wasnt nullable. It should be nullable because we are not creating enrollments when creating a student.
    }
}
