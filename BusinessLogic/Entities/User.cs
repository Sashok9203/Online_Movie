﻿
using BusinessLogic.Entities;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Data.Entities
{
	public class User : IdentityUser
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Birthdate { get; set; }
		public DateTime PremiumEndDate { get; set; }
		public Premium? Premium { get; set; }
		public int? PremiumId { get; set; }
		public ICollection<UserMovie> UserMovies { get; set; } = new HashSet<UserMovie>();
		public ICollection<Feedback> Feedbacks { get; set; } = new HashSet<Feedback>();
		public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
	}
}
