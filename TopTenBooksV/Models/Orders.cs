using System;
using System.Collections.Generic;

namespace TopTenBooksV.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Payment = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public int? BookId { get; set; }
        public decimal BookPrice { get; set; }
        public int? UserId { get; set; }

        public Library Book { get; set; }
        public Readers User { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
