using DataAccessLayer.UnitOfWorks;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer.Services.Concrete
{
	public class ImageService:IImageService
	{
		private readonly IUnitOfWork unitOfWork;
		public ImageService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task<bool> UploadProjectImage(Guid projectId, IFormFile file, string uploadPath, string relativePath)
		{
			string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
			string fullPath = Path.Combine(uploadPath, fileName);

			using (var stream = new FileStream(fullPath, FileMode.Create))
			{
				await file.CopyToAsync(stream);
			}

			var project = await unitOfWork.GetRepository<Project>().GetAsync(x => x.Id == projectId && !x.IsDeleted);
			if (project == null)
				return false;

			// wwwroot-dan sonrakı nisbətən yol (frontend üçün uyğun olacaq)
			string savedRelativePath = Path.Combine(relativePath, fileName).Replace("\\", "/");

			var projectImage = new ProjectImage
			{
				FilePath = savedRelativePath,  // Yalnız API-də işləyəcək nisbətən yol
				ProjectId = projectId
			};

			await unitOfWork.GetRepository<ProjectImage>().AddAsync(projectImage);
			await unitOfWork.SaveAsync();
			return true;
		}

	}
}
