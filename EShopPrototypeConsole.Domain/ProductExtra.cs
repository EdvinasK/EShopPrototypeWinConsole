﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class ProductExtra
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime? AvailabilityDate { get; set; }
    }
}
