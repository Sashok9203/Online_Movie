﻿using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Online_Movie.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private readonly IAccountsService accountsService;

		public AccountsController(IAccountsService accountsService)
		{
			this.accountsService = accountsService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterModel model)
		{
			await accountsService.Register(model);
			return Ok();
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginModel model)
		{
			await accountsService.Login(model);
			return Ok();
		}

		[Authorize]
		[HttpPost("logout")]
		public async Task<IActionResult> Logout()
		{
			await accountsService.Logout();
			return Ok();
		}

		[HttpPost("fogot")]
		
		public async Task<IActionResult> FogotPassword(string email)
		{
			var token = await accountsService.ResetPasswordRequest(email);
			return Ok(token);
		}

		[HttpPost("reset")]
		
		public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
		{
			await accountsService.ResetPassword(model);
			return Ok();
		}
	}
}
