﻿using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using DataAccess.Data.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace BusinessLogic.Services
{
	internal class MovieService : IMovieService
	{
		private readonly IRepository<Movie> movies;
		private readonly IRepository<Feedback> feedbacks;
		private readonly IRepository<StafMovie> stafMovie;
		private readonly IRepository<MovieGenre> movieGenre;
		private readonly IRepository<UserMovie> userMovie;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly IImageService imageService;
		

		public MovieService(IRepository<Movie> movies, IRepository<Feedback> feedbacks,
			                IRepository<StafMovie> stafMovie, IRepository<UserMovie> userMovie,
							IRepository<MovieGenre> movieGenre, IMapper mapper,
							IConfiguration configuration,IImageService imageService)
		{
			this.movies = movies;
			this.feedbacks = feedbacks;
			this.stafMovie = stafMovie;
			this.movieGenre = movieGenre;
			this.mapper = mapper;
			this.configuration = configuration;
			this.imageService = imageService;
			this.userMovie = userMovie;
		}
	

		public async Task DeleteAsync(int id)
		{
			if (id < 0) throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NegativeId"), HttpStatusCode.BadRequest);
			var movie = await movies.FirstOrDefaultAsync(selector:x=>x,
				                                           predicate: x=>x.Id == id,
														   include:item=>item
														   .Include(x=>x.Feedbacks)
														   .Include(x=>x.MovieGenres)
														   .Include(x=>x.StafMovies)
														   .Include(x => x.UserMovies)
														   .Include(x=>x.ScreenShots)) ?? throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NotFoundById"), HttpStatusCode.NotFound);
			
			foreach (var item in movie.Feedbacks)
				feedbacks.Delete(item);
			
			foreach (var item in movie.StafMovies)
				 stafMovie.Delete(item);
			
			foreach (var item in movie.MovieGenres)
			   	 movieGenre.Delete(item);
			
			foreach (var item in movie.UserMovies)
				 userMovie.Delete(item);
			

			//movie.StafMovies.Clear();
			//movie.MovieGenres.Clear();
			//movie.Feedbacks.Clear();
			//movie.UserMovies.Clear();
			//await movies.SaveAsync();
			await movies.DeleteAsync(id);
			await movies.SaveAsync();
			foreach (var item in movie.ScreenShots)
				imageService.DeleteImageByName(item.Name);
			imageService.DeleteImageByName(movie.Poster);
		}

		public async Task<IEnumerable<MovieDto>> GetAllAsync()
		{
			return mapper.Map<IEnumerable<MovieDto>>(await movies.GetAsync(selector: x => x,
															  include: item => item
																	   .Include(x => x.Country)
																	   .Include(x => x.Quality)
																	   .Include(x => x.Premium)));
		}

		public async Task<MovieDto> GetByIdAsync(int id)
		{
			return id < 0
				? throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NegativeId"), HttpStatusCode.BadRequest)
				: mapper.Map<MovieDto>(await movies.FirstOrDefaultAsync(selector: x => x,
																		 predicate:x => x.Id == id,
																		 include: item => item
																		  .Include(x => x.Country)
																		  .Include(x => x.Quality)
																		  .Include(x => x.Premium)) 
				                                                          ?? throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NotFoundById"), HttpStatusCode.NotFound));
		}

		public async Task<IEnumerable<FeedbackDto>> GetFeedbacksAsync(int id)
		{
			if (id < 0) throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NegativeId"), HttpStatusCode.BadRequest);
			return mapper.Map<IEnumerable<FeedbackDto>>(await feedbacks.GetAsync(selector: x => x,
				                                                                 predicate:x=>x.MovieId == id));
		}

		public async Task<IEnumerable<StafDto>> GetStafAsync(int id)
		{
			if (id < 0) throw new HttpException(configuration.GetValue<string>("HttpExceptionMessages:NegativeId"), HttpStatusCode.BadRequest);
			return mapper.Map<IEnumerable<StafDto>>(await stafMovie.GetAsync(selector: x => x,
																				 predicate: x => x.MovieId == id));
		}

		//public async Task<IEnumerable<MovieDto>> GetTopAsync(int count)
		//{
		//	var ratings = await feedbacks.GetAsync(selector:x=>x);
		//	var res = ratings.GroupBy(x => x.MovieId)
		//		                                               .Select(x=>  new {Id = x.Key,rating = x.Average(z=>z.Rating)})
		//												       .OrderByDescending(x=>x.rating).Take(count);
		//	return mapper.Map<IEnumerable<MovieDto>>(await movies.GetAsync(selector:x=>x,
		//		                                                           predicate:x=> res.Any(z=>z.Id == x.Id),
		//																   include: item=>item
		//																		   .Include(x => x.Country)
		//																           .Include(x => x.Quality)
		//																           .Include(x => x.Premium)));
		//}

		public Task CreateAsync(MovieModel movie)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(MovieModel movie)
		{
			throw new NotImplementedException();
		}

		public async Task<double> GetRatingAsync(int id) => (await GetFeedbacksAsync(id)).Average(x => x.Rating);
				
	}
}