using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
	public interface IImageService
	{
		Task<bool> UploadProjectImage(Guid projectId, IFormFile file, string uploadPath, string relativePath);
	}
}
