using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityApplication.Models.DbModels
{
    public class Course
    {
        [Display(Name = "Course Number")]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Course Title")]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
