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
	public class AchievementConfiguration : IEntityTypeConfiguration<Achievement>
	{
		public void Configure(EntityTypeBuilder<Achievement> builder)
		{
			builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Description).IsRequired();
			builder.Property(x => x.DateAchieved).IsRequired();
			Achievement achievement1 = new Achievement
			{
				Title = "Employee of the Month",
				Description = "Awarded for outstanding performance and dedication to the company.",
				DateAchieved = new DateTime(2024, 1, 15)
			};

			Achievement achievement2 = new Achievement
			{
				Title = "Certified C# Developer",
				Description = "Successfully completed the C# certification exam with high distinction.",
				DateAchieved = new DateTime(2023, 11, 20)
			};
			builder.HasData(achievement1, achievement2);
		}
	}
}
