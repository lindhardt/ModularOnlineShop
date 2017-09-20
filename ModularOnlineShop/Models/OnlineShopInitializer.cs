using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
    public class OnlineShopInitializer : DropCreateDatabaseAlways<OnlineShopContext> {
        protected override void Seed(OnlineShopContext context) {
            base.Seed(context);
        }
    }
}