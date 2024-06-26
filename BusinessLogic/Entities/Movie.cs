﻿namespace BusinessLogic.Data.Entities
{
	public class Movie : NameBaseEntity
	{
		public string OriginalName { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public Quality Quality { get; set; }
		public int QualityId { get; set; }
		public Country Country { get; set; }
		public int CountryId { get; set; }
		public string? Poster { get; set; }
		public string MovieUrl { get; set; }
		public string? TrailerUrl { get; set; }
		public Premium Premium { get; set; }
		public int PremiumId { get; set; }
		public ICollection<StafMovieRole> StafMovieRoles { get; set; } = new HashSet<StafMovieRole>();
		public ICollection<UserMovie> UserMovies { get; set; } = new HashSet<UserMovie>();
		public ICollection<Image> ScreenShots { get; set; } = new HashSet<Image>();
		public ICollection<MovieGenre> MovieGenres { get; set; } = new HashSet<MovieGenre>();
		public ICollection<Feedback> Feedbacks { get; set; } = new HashSet<Feedback>();
	}
}
