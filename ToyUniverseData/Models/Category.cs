using System;
using System.Collections.Generic;

namespace ToyUniverseData.Models
{
    public partial class Category
    {
        public Category()
        {
            Toys = new HashSet<Toy>();
        }

        public string CCategoryId { get; set; }
        public string CCategory { get; set; }
        public string VDescription { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
