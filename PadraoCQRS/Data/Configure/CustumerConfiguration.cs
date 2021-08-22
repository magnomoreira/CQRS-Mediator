using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PadraoCQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Data.Configure
{
	public class CustumerConfiguration : IEntityTypeConfiguration<Custumer>
	{
		public void Configure(EntityTypeBuilder<Custumer> builder)
		{
			builder.ToTable("custumer");
			builder.HasKey(p => p.Id);
			builder.Property(p => p.FirstName).HasColumnType("VARCHAR(15)").IsRequired();
			builder.Property(p => p.LastName).HasColumnType("VARCHAR(25)").IsRequired();
			builder.Property(p => p.Email).HasColumnType("VARCHAR(30)").IsRequired();
			builder.Property(p => p.Date).HasColumnType("datetime(6)");
		}
	
	}
	
	
}
