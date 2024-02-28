﻿using AutoMapper;
using BusinessLogic.Data.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NETCore.MailKit.Core;
using System.Data;
using System.Net;



namespace BusinessLogic.Services
{
    internal class AccountsService : IAccountsService
	{
		private readonly UserManager<User> userManager;
		private readonly SignInManager<User> signInManager;
		private readonly IMapper mapper;
		private readonly IValidator<RegisterModel> registerValidator;
		private readonly IValidator<ResetPasswordModel> resetModelValidator;
		private readonly IEmailService emailService;

		public AccountsService(UserManager<User> userManager,
								SignInManager<User> signInManager,
								IMapper mapper,
								IValidator<RegisterModel> registerValidator,
								IValidator<ResetPasswordModel> resetModelValidator,
								IEmailService emailService)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.mapper = mapper;
			this.registerValidator = registerValidator;
			this.resetModelValidator = resetModelValidator;
			this.emailService = emailService;
		}

		public async Task Register(RegisterModel model)
		{
			registerValidator.ValidateAndThrow(model);

			if (await userManager.FindByEmailAsync(model.Email) != null)
				throw new HttpException("Email is already exists.", HttpStatusCode.BadRequest);

			var user = mapper.Map<User>(model);

			var result = await userManager.CreateAsync(user, model.Password);
			await userManager.AddToRoleAsync(user, "User");
			if (!result.Succeeded)
				throw new HttpException(string.Join(" ", result.Errors.Select(x => x.Description)), HttpStatusCode.BadRequest);
		}

		public async Task Login(LoginModel model)
		{
			var user = await userManager.FindByEmailAsync(model.Email);

			if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
				throw new HttpException("Invalid login or password.", HttpStatusCode.BadRequest);

			await signInManager.SignInAsync(user, true);
		}

		public async Task Logout() =>await signInManager.SignOutAsync();

		
		public async Task<ResetPasswordResponse> ResetPasswordRequest(string email)
		{
			ResetPasswordResponse rModel = new(); 
			var user = await userManager.FindByEmailAsync(email);
			if (user != null)
			{
				rModel.Token = await userManager.GeneratePasswordResetTokenAsync(user);
				rModel.UserId = user.Id;
				await emailService.SendAsync(email,"Reset password",  $"\"Для сброса пароля пройдите по ссылке: <a href='#'>Reset password</a>\"",true);
			}
			return rModel;
		}

		public async Task ResetPassword(ResetPasswordModel model)
		{
			resetModelValidator.ValidateAndThrow(model);
			var user = await userManager.FindByIdAsync(model.UserId);
			var result = await userManager.ResetPasswordAsync(user,model.Token,model.Password);
			if (!result.Succeeded)
				throw new HttpException(string.Join(" ", result.Errors.Select(x => x.Description)), HttpStatusCode.BadRequest);
		}
	}
}
