using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
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
		public static void AddService(this IServiceCollection services)
		{
			services.AddScoped<IProjectService, ProjectService>();
			services.AddScoped<ISkillService, SkillService>();
			services.AddScoped<IImageService, ImageService>();
			var assembly=Assembly.GetExecutingAssembly();
			services.AddAutoMapper(assembly);
			services.AddValidatorsFromAssemblyContaining<ProjectValidator>();
		}
	}
}
