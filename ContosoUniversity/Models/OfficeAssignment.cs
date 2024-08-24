using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; } // OfficeAssignment can't exist without the Instructor, therefore it's primary key is also it's foreign key to the Instructor entity.
                                              // The EF won't recognize InstructorID as the primary key unless you follow the ID or classnameID naming convention. So we had to use the [Key] attribute to identify it as the key.
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
