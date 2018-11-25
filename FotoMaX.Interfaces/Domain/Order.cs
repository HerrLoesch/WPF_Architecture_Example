using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotoMaX.Interfaces.Domain
{
    public class Order
    {
        public Customer Customer { get; set; }

        public IEnumerable<Picture> Pictures { get; set; }

        public Decimal Price { get; set; }
    }
}
