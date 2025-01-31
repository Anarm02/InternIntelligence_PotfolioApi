using EntityLayer.DTOs.ContactMessage;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
	public interface IContactMessageService
	{
		Task CreateAsync(ContactMessageAddDto contactMessageAddDto);
		Task<IList<ContactMessage>> GetAllAsync();
	}
}
