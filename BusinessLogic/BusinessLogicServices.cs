﻿using AutoMapper;
using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using BusinessLogic.Mapping;
using BusinessLogic.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;


namespace BusinessLogic
{
    public class BusinessLogicServices : IModule
	{
		public IServiceCollection RegisterModule(IServiceCollection services, IConfiguration configuration)
		{
		    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddAutoMapper((serviceProvider, mapperConfiguration) => 
			{
				var request= serviceProvider?.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Request;
				var urlStr = new Uri($"{request?.Scheme}://{request?.Host.Host}:{request?.Host.Port}/{configuration["UserImgDir"]}").AbsoluteUri;
				mapperConfiguration.AddProfile(new MovieProfile(urlStr));
				mapperConfiguration.AddProfile(new StafProfile(urlStr));
				mapperConfiguration.AddProfile(new ImageProfile(urlStr));
				mapperConfiguration.AddProfile(new MovieModelProfile(urlStr));
			},
			AppDomain.CurrentDomain.GetAssemblies());

			//services.AddSingleton(provider => new MapperConfiguration(cfg =>
			//{
			//	cfg.AddProfile(new StaftProfile(provider.CreateScope().ServiceProvider.GetService<IFileService>()));

			//}).CreateMapper());
			
			//services.AddFluentValidationAutoValidation();
			// enable client-side validation
			//services.AddFluentValidationClientsideAdapters();
			// Load an assembly reference rather than using a marker type.
			services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

			services.AddScoped<IStafService, StafService>();

			services.AddScoped<IImageService, ImageService>();

			services.AddScoped<IMovieService, MovieService>();

			services.AddScoped<IAccountsService, AccountsService>();

			services.AddScoped<IDataService, DataService>();

			services.AddMailKit(optionBuilder =>
			{
				MailSettings? settings = configuration.GetSection("UkrNetMailSettings").Get<MailSettings>()
				                         ?? throw new HttpException("Error mail servise configuration",System.Net.HttpStatusCode.InternalServerError);
				optionBuilder.UseMailKit(new MailKitOptions()
				{
					Server = settings.Server,
					Port = settings.Port,
					SenderName = settings.SenderName,
					SenderEmail = settings.SenderEmail,
					Account = settings.Account,
					Password = settings.Password,
					Security = true
				});
			});

			services.AddScoped<IJwtService, JwtService>();

			return services;
		}
	}
}
