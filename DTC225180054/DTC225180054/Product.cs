using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTC225180054
{
    internal class Product
    {
        public int Id { get; set; }

        // Thuộc tính Name tương ứng với cột Name
        public string? Name { get; set; }

        // Thuộc tính Price tương ứng với cột Price
        public decimal Price { get; set; }

        // Thuộc tính Quantity tương ứng với cột Quantity
        public int Quantity { get; set; }
        
        public string? Description { get; set; }
    }
}
