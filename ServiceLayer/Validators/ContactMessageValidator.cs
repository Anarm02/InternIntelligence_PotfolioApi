using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
	public class ContactMessageValidator:AbstractValidator<ContactMessage>
	{
		public ContactMessageValidator()
		{
			RuleFor(x=>x.Email).NotEmpty().EmailAddress().MinimumLength(5);
			RuleFor(x=>x.Name).NotEmpty().MinimumLength(2);
			RuleFor(x=>x.Subject).NotEmpty().MinimumLength(5);
			RuleFor(x=>x.Message).NotEmpty().MinimumLength(8);
		}
	}
}
