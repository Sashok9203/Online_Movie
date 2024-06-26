﻿using Ardalis.Specification;
using BusinessLogic.Data.Entities;
using BusinessLogic.Models;
using System.Linq.Expressions;

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
					.Include(x => x.StafMovieRoles)
					.Include(x => x.UserMovies)
					.Include(x => x.ScreenShots);
			}
		}

		public class GetByIdIncScreenShots : Specification<Movie>
		{
			public GetByIdIncScreenShots(int id)
			{
				Query
					.Where(x => x.Id == id)
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
					.Include(x => x.Premium)
					.Include(x=>x.Feedbacks);
			}
		}
		public class GetByIdsInc : Specification<Movie>
		{
			public GetByIdsInc(IEnumerable<int> ids)
			{
				Query
					.Where(x => ids.Contains(x.Id))
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium)
					.Include(x=>x.Feedbacks);
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

		public class GetWithNotApprovedFeedbacks : Specification<Movie>
		{
			public GetWithNotApprovedFeedbacks()
			{
				Query.Include(x => x.Feedbacks)
					.Where(x=>x.Feedbacks.Any(z=>!z.Approved));
			}
		}

		public class GetAllIncFeedbacks : Specification<Movie>
		{
			public GetAllIncFeedbacks()
			{
				Query
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium)
					.Include(x => x.Feedbacks);
			}
		}

		public class Find : Specification<Movie>
		{

			public Find(MovieFindFilterModel movieFindFilter)
			{
				 
				Query
					.Where(findMovie(movieFindFilter))
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium);
			}
			private Expression<Func<Movie, bool>> findMovie(MovieFindFilterModel movieFindFilter)
			{
				Expression<Func<Movie, bool>> ResultExp   = x => true;
				Expression<Func<Movie, bool>> NameExpr    = x => x.Name.ToLower().Contains(movieFindFilter.Name.ToLower());
				Expression<Func<Movie, bool>> OrNameExpr  = x => x.OriginalName.ToLower().Contains(movieFindFilter.OriginalName.ToLower());
				Expression<Func<Movie, bool>> YearExpr    = x => movieFindFilter.Years.Contains(x.Date.Year);
				Expression<Func<Movie, bool>> QualityExpr = x => movieFindFilter.Qualities.Contains(x.QualityId);
				Expression<Func<Movie, bool>> CountryExpr = x => movieFindFilter.Countries.Contains(x.CountryId);
				Expression<Func<Movie, bool>> AllStafExpr = x => movieFindFilter.Stafs.All(z => x.StafMovieRoles.Any(y => y.StafId == z));
				Expression<Func<Movie, bool>> StafExpr    = x => x.StafMovieRoles.Any(x => movieFindFilter.Stafs.Contains(x.StafId));
				Expression<Func<Movie, bool>> AllGenresExpr = x => movieFindFilter.Genres.All(z => x.MovieGenres.Any(y => y.GenreId == z));
				Expression<Func<Movie, bool>> GenresExpr  = x => x.MovieGenres.Any(x => movieFindFilter.Genres.Contains(x.GenreId));
				Expression<Func<Movie, bool>> PremExpr = x => movieFindFilter.Premiums.Contains(x.PremiumId);

				if (!string.IsNullOrEmpty(movieFindFilter.Name))
					ResultExp = ResultExp.AndAlso(NameExpr);
				if (!string.IsNullOrEmpty(movieFindFilter.OriginalName))
					ResultExp = ResultExp.AndAlso(OrNameExpr);
				if (movieFindFilter.Years.Count != 0)
					ResultExp = ResultExp.AndAlso(YearExpr);
				if (movieFindFilter.Qualities.Count != 0)
					ResultExp = ResultExp.AndAlso(QualityExpr);
				if (movieFindFilter.Premiums.Count != 0)
					ResultExp = ResultExp.AndAlso(PremExpr);
				if (movieFindFilter.Countries.Count != 0)
					ResultExp = ResultExp.AndAlso(CountryExpr);
				if (movieFindFilter.Stafs.Count != 0)
				{
					if (movieFindFilter.AllStafs)
						ResultExp = ResultExp.AndAlso(AllStafExpr);
					else
						ResultExp = ResultExp.AndAlso(StafExpr);
				}
				if (movieFindFilter.Genres.Count != 0)
				{
					if (movieFindFilter.AllGenres)
						ResultExp = ResultExp.AndAlso(AllGenresExpr);
					else
						ResultExp = ResultExp.AndAlso(GenresExpr);
				}
				return ResultExp;
     		}
    	}

		
		public class Take : Specification<Movie>
		{
			public Take(int skip, int count)
			{
				Query
					.Skip(skip)
					.Take(count)
					.Include(x => x.Country)
					.Include(x => x.Quality)
					.Include(x => x.Premium);
			}
		}
    }
}
