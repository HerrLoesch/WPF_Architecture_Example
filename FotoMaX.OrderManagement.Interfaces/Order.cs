namespace FotoMaX.OrderManagement.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public Customer Customer { get; set; }

        public IEnumerable<Picture> Pictures { get; set; }

        public Decimal Price { get; set; }
    }
}
