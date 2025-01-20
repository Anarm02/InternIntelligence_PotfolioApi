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
	public class SkillConfiguration : IEntityTypeConfiguration<Skill>
	{
		public void Configure(EntityTypeBuilder<Skill> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x=>x.ProfiencyLevel).IsRequired().HasMaxLength(50);
			Skill skill1 = new Skill
			{
				Name = "C# Programming",
				ProfiencyLevel = "Advanced"
			};

			Skill skill2 = new Skill
			{
				Name = "Web Development",
				ProfiencyLevel = "Intermediate"
			};
			builder.HasData(skill1,skill2);
		}
	}
}
