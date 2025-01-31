using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
	public class ContactMessageConfiguration : IEntityTypeConfiguration<ContactMessage>
	{
		public void Configure(EntityTypeBuilder<ContactMessage> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x=>x.Subject).IsRequired();
			builder.Property(x=>x.Email).IsRequired().HasMaxLength(100);
		
		}
	}
}
