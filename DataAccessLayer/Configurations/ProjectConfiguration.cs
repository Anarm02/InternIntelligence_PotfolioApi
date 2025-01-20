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
	public class ProjectConfiguration : IEntityTypeConfiguration<Project>
	{
		public void Configure(EntityTypeBuilder<Project> builder)
		{
			builder.Property(x => x.Title).IsRequired().HasMaxLength(30);
			builder.Property(x=>x.Description).IsRequired();
			builder.Property(x => x.ProjectUrl).IsRequired();
			Project project1 = new Project
			{
				Title = "E-Commerce Website",
				Description = "A fully responsive e-commerce platform with payment integration and user authentication.",
				ProjectUrl = "https://www.myecommerceproject.com"
			};

			Project project2 = new Project
			{
				Title = "Task Management App",
				Description = "A web-based task management application to help teams collaborate effectively.",
				ProjectUrl = "https://www.taskmanagerapp.com"
			};
			builder.HasData(project1, project2);
		}
	}
}
