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

		[AllowAnonymous]
		[HttpGet("getmovieroles/{stafId:int}/{movieId:int}")]
		public async Task<IActionResult> GetMovieRoles([FromRoute] int stafId,int movieId) => Ok(await stafService.GetMovieRolesAsync(stafId, movieId));

		[AllowAnonymous]
		[HttpGet("getstafpagination")]
		public async Task<IActionResult> GetStafWithPagination([FromQuery] int pageSize, int pageIndex) => Ok(await stafService.GetStafWithPaginationAsync(pageSize, pageIndex));

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

		
	}
}
