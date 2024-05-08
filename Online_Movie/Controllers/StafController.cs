﻿using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using BusinessLogic.ModelDto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Online_Movie.Controllers
{
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[Route("api/[controller]")]
	[ApiController]
	public class StafController : ControllerBase
	{
		private readonly IStafService stafService;

		public StafController(IStafService stafService)
		{
			this.stafService = stafService;
		}

		[AllowAnonymous]
		[HttpGet("getall")]
		public async Task<IActionResult> GetAll() => Ok(await stafService.GetAllAsync());

		[AllowAnonymous]
		[HttpGet("get/{id:int}")]
		public async Task<IActionResult> Get([FromRoute]int id) =>Ok(await stafService.GetAsync(id));

		[AllowAnonymous]
		[HttpGet("getmovies/{id:int}")]
		public async Task<IActionResult> GetMovies([FromRoute] int id) => Ok(await stafService.GetMoviesAsync(id));

		[AllowAnonymous]
		[HttpGet("getroles/{id:int}")]
		public async Task<IActionResult> GetRoles([FromRoute] int id) => Ok(await stafService.GetRolesAsync(id));

		[Authorize(Roles = Roles.Admin)]
		//[AllowAnonymous]
		[HttpPut("update")]
		public async Task<IActionResult> Update([FromForm] StafModel staf)
		{
			await stafService.UpdateAsync(staf);
			return Ok();
		}

		[Authorize(Roles = Roles.Admin)]
		//[AllowAnonymous]
		[HttpPost("create")]
		public async Task<IActionResult> Create([FromForm] StafModel staf)
		{
			await stafService.CreateAsync(staf);
			return Ok();
		}

		[Authorize(Roles = Roles.Admin)]
		//[AllowAnonymous]
		[HttpDelete("delete/{id:int}")]
		public async Task<IActionResult> Delete([FromRoute]int id)
		{
			await stafService.DeleteAsync(id);
			return Ok();
		}

		[AllowAnonymous]
		[HttpGet("take")]
		public async Task<IActionResult> Take([FromQuery] int skip, int count) => Ok(await stafService.TakeAsync(skip, count));
	}
}
