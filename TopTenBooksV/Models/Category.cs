using System;
using System.Collections.Generic;

namespace TopTenBooksV.Models
{
    public partial class Category
    {
        public Category()
        {
            Library = new HashSet<Library>();
        }

        public decimal CategoryId { get; set; }
        public string TitleName { get; set; }

        public ICollection<Library> Library { get; set; }
    }
}
