using System;
using System.Data.Entity;

namespace Seoul_Software.SQL
{
	public class SeoulDbContext : DbContext
	{
		public SeoulDbContext() : base(MySetting.Setting.ConnectionString)
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<SeoulDbContext>());
		}
		public DbSet<LotModel> Lots { get; set; }
		public DbSet<RingModel> Rings { get; set; }
	}
}
