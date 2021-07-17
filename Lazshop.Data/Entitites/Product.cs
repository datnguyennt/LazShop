using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lazshop.Data.Entitites
{
	public class Product
	{
		public int ID { get; set; }
		public decimal Price { get; set; }
		public decimal OriginalPrice { get; set; }
		public int Stock { get; set; }
		public int ViewCount { get; set; }
		public DateTime DateCreated { get; set; }

		[Required]
		public string SeoAlias { get; set; }
	}
}
