﻿using Ardalis.Specification;
using BusinessLogic.Data.Entities;


namespace BusinessLogic.Specifications
{
	public static class MovieSpecs
	{
		public class GetByIdIncCollections : Specification<Movie>
		{
			public GetByIdIncCollections(int id)
			{
				Query
					.Where(x => x.Id == id)
					.Include(x => x.Feedbacks)
					.Include(x => x.MovieGenres)
					.Include(x => x.StafMovies)
					.Include(x => x.UserMovies)
					.Include(x => x.ScreenShots);
			}
		}
		public class GetByIdInc : Specification<Movie>
		{
			public GetByIdInc(int id)
			{
				Query
					.Where(x => x.Id == id)
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium);
			}
		}

		public class GetAll : Specification<Movie>
		{
			public GetAll()
			{
				Query
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium);
			}
		}
		
		
	}
}