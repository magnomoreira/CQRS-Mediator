using Microsoft.EntityFrameworkCore;
using PadraoCQRS.Domain;

namespace PadraoCQRS.Data
{
	public class AplicationContext : DbContext
	{
		public DbSet<Custumer> Custumers {get; set;}
		public AplicationContext() { }
		public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(AplicationContext).Assembly);
		}
	}
}
