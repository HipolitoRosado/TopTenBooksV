using System;
using System.Collections.Generic;

namespace TopTenBooksV.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string CardNumber { get; set; }
        public string VerificationNumber { get; set; }
        public int? UserId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? ExperationDate { get; set; }

        public Orders Order { get; set; }
        public Readers User { get; set; }
    }
}
