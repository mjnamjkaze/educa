using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VnEduca.Models
{
    public class Lession
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Type { get; set; }
        public int ObjectId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }


        public int SortOrder { get; set; }
        public virtual Course Course { get; set; }

        public virtual VideoLesstion Video { get; set; }
        public virtual TextLesstion Text { get; set; }
    }
}
