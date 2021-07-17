using System;
using System.Collections.Generic;
using System.Text;

namespace Lazshop.Data.Entitites
{
	public class OrderDetail
	{
        

        public List<OrderDetail> OrderDetails { get; set; }

        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
