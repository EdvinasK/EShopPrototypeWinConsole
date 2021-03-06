﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain.DataLayerAbstractions
{
    public interface ICartRepository
    {
        int GetCartProductCount(int CartId);
        List<Product> GetAllCartProducts(int CartId);
    }
}
