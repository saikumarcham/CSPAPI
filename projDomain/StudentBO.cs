using System;

namespace projDomain
{
    public class StudentBO
    {
        public string sid { get; set; }
        public string name { get; set; }
        public string Cource { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public StudentAddressBO Address { get; set; }
    }

    public class StudentAddressBO
    {

        public string aid { get; set; }
        public string street { get; set; }
        public string City { get; set; }
    }
}
