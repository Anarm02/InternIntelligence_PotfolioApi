﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.Skills
{
	public class SkillUpdateDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string ProfiencyLevel { get; set; }
	}
}
