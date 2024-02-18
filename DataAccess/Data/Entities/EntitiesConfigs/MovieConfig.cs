﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data.Entities.EntitiesConfigs
{
	internal class MovieConfig : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(256);
			builder.Property(x => x.OriginalName).HasMaxLength(256);
			builder.Property(x => x.Poster).HasDefaultValue("noposter.png");
			builder.HasOne(x => x.Quality)
				   .WithMany(x => x.Movies)
				   .HasForeignKey(x=>x.QualityId);
			builder.HasOne(x => x.Country)
				   .WithMany(x => x.Movies)
				   .HasForeignKey(x => x.CountryId);
			builder.ToTable(t => t.HasCheckConstraint("Name_check", "[Name] <> ''"));
			builder.ToTable(t => t.HasCheckConstraint("OriginalName_check", "[OriginalName] <> ''"));
		}
	}
}
