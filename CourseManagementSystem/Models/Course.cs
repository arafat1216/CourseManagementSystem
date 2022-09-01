using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementSystem.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Credits { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
    }
}