using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VnEduca.Models
{
    public class Lession
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int LessionCategoryId { get; set; }
        public string Type { get; set; }
        public int ObjectId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }


        public int SortOrder { get; set; }
        public virtual Course Course { get; set; }
        public virtual LessionCategory LessionCategory { get; set; }

        public virtual VideoLesstion Video { get; set; }
        public virtual TextLesstion Text { get; set; }
    }
}
