using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lazshop.Data.EF
{
	class LazShopDbContextFactory : IDesignTimeDbContextFactory<LazShopDbContext>
	{
		public LazShopDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			   .SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsetting.json")
			   .Build();

			var connectionString = configuration.GetConnectionString("LazShopDatabase");
			var optionsBuilder = new DbContextOptionsBuilder<LazShopDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new LazShopDbContext(optionsBuilder.Options);
		}
	}
}
