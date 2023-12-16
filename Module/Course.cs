using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.Module
{
    public class Course
    {
        [Key]
         public int CourseKey { get; set; }

        public String Name { get; set; }

        public String LectureName { get; set; }
    }
}
