﻿using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using BusinessLogic.ModelDto;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Online_Movie.Controllers
{
	
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Roles = Roles.Admin)]
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		private readonly IMovieService movieService;

		public MovieController(IMovieService movieService)
        {
			this.movieService = movieService;
		}

		[AllowAnonymous]
		[HttpGet("getall")]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await movieService.GetAllAsync());
		}

		[AllowAnonymous]
		[HttpGet("take")]
		public async Task<IActionResult> Take([FromQuery] int skip,int count) => Ok(await movieService.TakeAsync(skip, count));
		
		[AllowAnonymous]
		[HttpGet("get/{id:int}")]
		public async Task<IActionResult> Get([FromRoute] int id) => Ok(await movieService.GetByIdAsync(id));

		[AllowAnonymous]
		[HttpGet("gettop")]
		public async Task<IActionResult> GetTop([FromQuery] int count)
		{
			var topMovies = await movieService.GetTopByRatingAsync(count);
			return Ok(topMovies);
		}

		[AllowAnonymous]
		[HttpGet("getscreens/{id:int}")]
		public async Task<IActionResult> GetScreens([FromRoute] int id)
		{
			return Ok(await movieService.GetScreensAsync(id));
		}

		[AllowAnonymous]
		[HttpGet("getstafs/{id:int}")]
		public async Task<IActionResult> GetStafs([FromRoute] int id)
		{
			return Ok(await movieService.GetStafAsync(id));
		}

		[AllowAnonymous]
		[HttpGet("getfeedbacks/{id:int}")]
		public async Task<IActionResult> GetFeedbacks([FromRoute] int id)
		{
			return Ok(await movieService.GetFeedbacksAsync(id));
		}

		[AllowAnonymous]
		[HttpGet("getrating/{id:int}")]
		public async Task<IActionResult> GetRating([FromRoute] int id)
		{
			return Ok(await movieService.GetRatingAsync(id));
		}

		[AllowAnonymous]
		[HttpGet("getgenres/{id:int}")]
		public async Task<IActionResult> GetGenres([FromRoute] int id)
		{
			return Ok(await movieService.GetGenresAsync(id));
		}

		[AllowAnonymous]
		[HttpPost("find")]
		public async Task<IActionResult> Find([FromForm] MovieFindFilterModel movieFilter)
		{
			return Ok(await movieService.FindAsync(movieFilter));
		}
		[AllowAnonymous]
		[HttpPost("create")]
		public async Task<IActionResult> Create([FromForm] MovieModel movie)
		{
			await movieService.CreateAsync(movie);
			return Ok();
		}
		[AllowAnonymous]
		[HttpPut("update")]
		public async Task<IActionResult> Update([FromForm] MovieModel movie)
		{
			await movieService.UpdateAsync(movie);
			return Ok();
		}

		[AllowAnonymous]
		[HttpDelete("delete/{id:int}")]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			await movieService.DeleteAsync(id);
			return Ok();
		}
    }
}
