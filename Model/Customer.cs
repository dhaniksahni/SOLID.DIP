using System;

namespace SOLID.DIP.Model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBorth { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }

    }
}