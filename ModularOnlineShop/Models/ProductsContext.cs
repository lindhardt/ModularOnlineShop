﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ModularOnlineShop.Models {
    public class ProductsContext : DbContext {

        public DbSet<Product> Products { get; set; }

        
    }
}