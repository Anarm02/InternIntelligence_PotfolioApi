using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
	public class SkillValidator:AbstractValidator<Skill>
	{
		public SkillValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().MinimumLength(2);
			RuleFor(x=>x.ProfiencyLevel).NotEmpty().MinimumLength(2);
		}
	}
}
