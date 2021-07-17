using Lazshop.Data.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lazshop.Data.Configurations
{
	public class AppconfigConfiguration : IEntityTypeConfiguration<Appconfig>
	{
		public void Configure(EntityTypeBuilder<Appconfig> builder)
		{
			builder.ToTable("Appconfigs"); //Table name
			builder.HasKey(x => x.Key); // Primary key
			builder.Property(x => x.Value).IsRequired(true); //Another field
		}
	}
}
