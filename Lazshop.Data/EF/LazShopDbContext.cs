using Lazshop.Data.Configurations;
using Lazshop.Data.Entitites;
using Lazshop.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lazshop.Data.EF
{
	class LazShopDbContext : IdentityDbContext<AppUser, AppRole, Guid>
	{
		public LazShopDbContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CartConfiguration());

			modelBuilder.ApplyConfiguration(new AppconfigConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new ProductIncategoryConfiguration());
			modelBuilder.ApplyConfiguration(new OrderConfiguration());

			modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
			modelBuilder.ApplyConfiguration(new ContactConfiguration());
			modelBuilder.ApplyConfiguration(new LanguageConfiguration());
			modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
			modelBuilder.ApplyConfiguration(new PromotionConfiguration());
			modelBuilder.ApplyConfiguration(new TransactionConfiguration());

			modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
			modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
			modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

			modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
			modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

			modelBuilder.Seed();
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
