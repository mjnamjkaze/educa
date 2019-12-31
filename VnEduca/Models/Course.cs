using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VnEduca.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
