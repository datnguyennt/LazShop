using Lazshop.Data.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lazshop.Data.Configurations
{
	class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.ToTable("Carts");
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).UseIdentityColumn();


			builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
		}
	}
}
