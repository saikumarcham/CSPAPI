using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteInstitute.DTO
{
    public class Student
    {
        public decimal sid { get; set; }
        public string name { get; set; }
        public string Cource { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<StudentAddress> Address { get; set; } = new List<StudentAddress>();
    }

    public class StudentAddress
    {
        public decimal aid { get; set; }
        public string street { get; set; }
        public string City { get; set; }
    }
}
