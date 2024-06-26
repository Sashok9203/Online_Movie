﻿using BusinessLogic.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



namespace DataAccess.Data
{
    internal class OnlineMovieDBContext : IdentityDbContext<User>
	{
		public OnlineMovieDBContext(DbContextOptions options) : base(options) 
		{
			//Database.EnsureDeleted();
			//Database.EnsureCreated();
			Database.Migrate();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			DefaultUsers.Initialize(modelBuilder);
			DefaultData.Initialize(modelBuilder);
		}
	}
}
