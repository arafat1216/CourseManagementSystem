namespace CourseManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int DepartmentId { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
        public Department? Department { get; set; }
    }
}
