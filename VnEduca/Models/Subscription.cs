using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VnEduca.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public virtual Account Account { get; set; }
        public virtual Course Course { get; set; }
        public bool IsPreview { get; set; } = true;
        public DateTime CreatedDate { get; set; }
    }
}
