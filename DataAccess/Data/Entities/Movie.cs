﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Entities
{
	public class Movie : NameBaseEntity
	{
		public string OriginalName { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }
		public Quality Quality { get; set; }
		public int QualityId { get; set; }
		public Country Country { get; set; }
		public int CountryId { get; set; }
		public string? Poster { get; set; }
		public IEnumerable<StafMovie> StafMovies { get; set; } = new HashSet<StafMovie>();
		public IEnumerable<UserMovie> UserMovies { get; set; } = new HashSet<UserMovie>();
		public IEnumerable<MovieImage> MovieImages { get; set; } = new HashSet<MovieImage>();
		public IEnumerable<MovieGenre> MovieGenres { get; set; } = new HashSet<MovieGenre>();
	}
}
