using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.ContactMessage;
using EntityLayer.Entities;
using FluentValidation;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Concrete
{
	public class ContactMessageService : IContactMessageService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly IValidator<ContactMessage> _validator;

		public ContactMessageService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<ContactMessage> validator)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_validator = validator;
		}

		public async Task CreateAsync(ContactMessageAddDto contactMessageAddDto)
		{
			var map = _mapper.Map<ContactMessage>(contactMessageAddDto);
			var res=await _validator.ValidateAsync(map);
			if (!res.IsValid)
			{
				var errors=res.Errors.Select(x=>x.ErrorMessage);
				throw new ValidationException(string.Join(" , ",errors));
			}
			await _unitOfWork.GetRepository<ContactMessage>().AddAsync(map);
			await _unitOfWork.SaveAsync();
		}

		public async Task<IList<ContactMessage>> GetAllAsync()
		{
			var messages=await _unitOfWork.GetRepository<ContactMessage>().GetAllAsync(x=>!x.IsDeleted);
			return messages;
		}
	}
}
