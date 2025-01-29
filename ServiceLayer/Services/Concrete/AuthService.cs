﻿using EntityLayer.DTOs.Auth;
using EntityLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Concrete
{
	public class AuthService : IAuthService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly ITokenService _tokenService;

		public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_tokenService = tokenService;
		}

		public async Task<AuthResponseDto> Login(LoginDto loginDto)
		{
			var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, true, false);
			if (result.Succeeded)
			{
				var user = await _userManager.FindByEmailAsync(loginDto.Email);
				if (user != null)
				{
					var res = _tokenService.CreateToken(user);
					user.RefreshToken = res.RefreshToken;
					user.RefreshTokenExpiration = res.RefreshTokenExpiration;
					await _userManager.UpdateAsync(user);
					return res;
				}
				throw new Exception("No user found");
			}
			else
			{
				throw new Exception("Wrong email or password");
			}
		}
	}
}
