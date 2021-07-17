﻿using Lazshop.Data.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lazshop.Data.EF
{
	class LazShopDbContext : DbContext
	{
		public LazShopDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Appconfig> AppConfigs { get; set; }

		public DbSet<Cart> Carts { get; set; }

		public DbSet<CategoryTranslation> CategoryTranslations { get; set; }

		public DbSet<ProductInCategory> ProductInCategories { get; set; }

		public DbSet<Contact> Contacts { get; set; }

		public DbSet<Language> Languages { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<ProductTranslation> ProductTranslations { get; set; }

		public DbSet<Promotion> Promotions { get; set; }

		public DbSet<Transaction> Transactions { get; set; }
	}
}
