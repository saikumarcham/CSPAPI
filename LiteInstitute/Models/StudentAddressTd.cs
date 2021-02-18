using System;
using System.Collections.Generic;

#nullable disable

namespace LiteInstitute.Models
{
    public partial class StudentAddressTd
    {
        public decimal Aid { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public decimal? Sid { get; set; }

        public virtual StudentTd SidNavigation { get; set; }
    }
}
