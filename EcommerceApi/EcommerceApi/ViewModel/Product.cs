using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.ViewModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string Vendor { get; set; }
    }
}
