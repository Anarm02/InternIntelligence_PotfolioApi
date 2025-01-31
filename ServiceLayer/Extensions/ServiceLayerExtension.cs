using DataAccessLayer.DataContext;
using EntityLayer.Entities.Identity;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;
using ServiceLayer.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Extensions
{
	public static class ServiceLayerExtension
	{
		public static void AddService(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddScoped<IProjectService, ProjectService>();
			services.AddScoped<ISkillService, SkillService>();
			services.AddScoped<IImageService, ImageService>();
			services.AddScoped<IAchievementService, AchievementService>();
			services.AddScoped<ITokenService, TokenService>();	
			services.AddScoped<IAuthService, AuthService>();	
			services.AddScoped<IContactMessageService, ContactMessageService>();
			var assembly=Assembly.GetExecutingAssembly();
			services.AddAutoMapper(assembly);
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
			services.AddAuthentication(opt =>
			{
				opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(opt =>
			{
				opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
				{
					ValidateIssuer = true,
					ValidIssuer = configuration["Jwt:Issuer"],
					ValidateAudience = true,
					ValidAudience = configuration["Jwt:Audience"],
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Secret"]))
				};
			});
			services.AddAuthorization();
			services.AddValidatorsFromAssemblyContaining<ProjectValidator>();
		}
	}
}
