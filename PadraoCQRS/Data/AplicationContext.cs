using Microsoft.EntityFrameworkCore;
using PadraoCQRS.Domain;

namespace PadraoCQRS.Data
{
	public class AplicationContext : DbContext
	{

		public DbSet<Custumer> Custumers { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
		{
			optionsbuilder.UseSqlServer("");
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(AplicationContext).Assembly);
		}
	}
}
