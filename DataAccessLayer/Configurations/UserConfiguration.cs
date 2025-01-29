using EntityLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			var superadmin = new AppUser
			{
				Id = Guid.Parse("60F812E7-9374-4623-873B-C28D9F6437E4"),
				UserName = "superadmin@gmail.com",
				NormalizedUserName = "SUPERADMIN@GMAIL.COM",
				Email = "superadmin@gmail.com",
				NormalizedEmail = "SUPERADMIN@GMAIL.COM",
				PhoneNumber = "+9940506983552",
				FullName = "Anar Mammadli",
				PhoneNumberConfirmed = true,
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),

			};
			superadmin.PasswordHash = CreatePasswordHash(superadmin, "Anar_1234");
			builder.HasData(superadmin);	
		}

		private string CreatePasswordHash(AppUser user, string password)
		{
			var passwordhash = new PasswordHasher<AppUser>();
			return passwordhash.HashPassword(user, password);
		}
	} }
