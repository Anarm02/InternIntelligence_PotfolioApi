using AutoMapper;
using EntityLayer.DTOs.ContactMessage;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper
{
	public class ContactMessageProfile : Profile
	{
		public ContactMessageProfile()
		{
			CreateMap<ContactMessage,ContactMessageAddDto>().ReverseMap();
		}
	}
}
