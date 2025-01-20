using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
	public class ProjectValidator:AbstractValidator<Project>
	{
		public ProjectValidator()
		{
			RuleFor(x => x.Title).NotEmpty().MinimumLength(3).MaximumLength(30);
			RuleFor(x => x.Description).NotEmpty().MinimumLength(5);
			RuleFor(x => x.ProjectUrl).NotEmpty();
		}
	}
}
