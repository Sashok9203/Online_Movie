﻿namespace BusinessLogic.DTOs
{
	public class StafDto :NameBaseDto
	{
		public string? Surname { get; set; }
		public string? Description { get; set; }
		public string? ImageName { get; set; }
		public string? CountryName { get; set; }
		public int CountryId { get; set; }
		public DateTime Birthdate { get; set; }
		public bool IsOscar { get; set; }
	}
}
