using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public class Department
    {
        public Department()
        {
            this.Courses = new HashSet<Course>();
        }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
