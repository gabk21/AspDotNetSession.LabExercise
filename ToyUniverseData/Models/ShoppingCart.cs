using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyUniverseData.Models
{
    public partial class ShoppingCart
    {
        public string CCartId { get; set; }
        public string CToyId { get; set; }
        public int SiQty { get; set; }

        public virtual Toy CToy { get; set; }
    }
}
