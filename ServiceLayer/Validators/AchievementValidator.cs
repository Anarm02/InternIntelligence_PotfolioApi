using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
	public class AchievementValidator:AbstractValidator<Achievement>
	{
		public AchievementValidator()
		{
			RuleFor(x=>x.Title).NotEmpty().MinimumLength(2).MaximumLength(20);
			RuleFor(x => x.Description).NotEmpty().MinimumLength(8);
		}
	}
}
