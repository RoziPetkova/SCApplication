using System.ComponentModel.DataAnnotations;

namespace SCApplication.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        [Required]
        public int CourseID { get; set; }
        [Required]
        public int StudentID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}