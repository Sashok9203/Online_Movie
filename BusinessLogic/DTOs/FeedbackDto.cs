﻿namespace BusinessLogic.DTOs
{
	public class FeedbackDto : BaseDto
	{
		public string Text { get; set; }
		public double Rating { get; set; }
		public string UserId { get; set; }
		public int MovieId { get; set; }
	}
}
