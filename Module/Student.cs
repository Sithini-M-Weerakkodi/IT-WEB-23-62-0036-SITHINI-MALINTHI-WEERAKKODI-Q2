using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.Module
{
    public class Student
    {
        [Key]
        public int StudentKey { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public int CourseKey { get; set; }

    }
}
