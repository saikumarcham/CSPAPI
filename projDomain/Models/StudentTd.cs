using System;
using System.Collections.Generic;

#nullable disable

namespace projDomain.Models
{
    public partial class StudentTd
    {
        public StudentTd()
        {
            StudentAddressTds = new HashSet<StudentAddressTd>();
        }

        public decimal Sid { get; set; }
        public string Name { get; set; }
        public string Cource { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<StudentAddressTd> StudentAddressTds { get; set; }
    }
}
