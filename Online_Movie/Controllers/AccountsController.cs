﻿using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
		public async Task<IActionResult> Login([FromBody] LoginModel model) => Ok(await accountsService.Login(model));

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpPost("logout")]
		public async Task<IActionResult> Logout()
		{
			await accountsService.Logout();
			return Ok();
		}

		[HttpPost("fogot")]
		public async Task<IActionResult> FogotPassword([FromRoute] string email) => Ok(await accountsService.ResetPasswordRequest(email));
		

		[HttpPost("reset")]
		public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
		{
			await accountsService.ResetPassword(model);
			return Ok();
		}

		[HttpDelete("{*email}")]
		public async Task<IActionResult> Delete([FromRoute]string email)
		{
			await accountsService.Delete(email);
			return Ok();
		}
	}
}
