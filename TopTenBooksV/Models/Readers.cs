using System;
using System.Collections.Generic;

namespace TopTenBooksV.Models
{
    public partial class Readers
    {
        public Readers()
        {
            Orders = new HashSet<Orders>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Useraccountid { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
