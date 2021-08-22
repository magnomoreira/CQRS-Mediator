using Microsoft.EntityFrameworkCore;
using PadraoCQRS.Domain;

namespace PadraoCQRS.Data
{
	public class AplicationContext : DbContext
	{

		public AplicationContext() { }
		public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

		public DbSet<Custumer> Custumers { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(AplicationContext).Assembly);
		}
	}
}
