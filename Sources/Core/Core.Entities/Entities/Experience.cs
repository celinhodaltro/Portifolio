using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Experience
    {
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? CompanyImage { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string? Description { get; set; }
    }
}
