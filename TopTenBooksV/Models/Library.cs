using System;
using System.Collections.Generic;

namespace TopTenBooksV.Models
{
    public partial class Library
    {
        public Library()
        {
            Orders = new HashSet<Orders>();
        }

        public int BookId { get; set; }
        public decimal? CategoryId { get; set; }
        public string TitleName { get; set; }
        public string AuthorName { get; set; }
        public string PublishYear { get; set; }

        public Category Category { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
