﻿using Microsoft.AspNetCore.Identity;
using STAGGI_Budget_API.DTOs;
using STAGGI_Budget_API.Helpers;
using STAGGI_Budget_API.Models;
using System.Collections.Generic;

namespace STAGGI_Budget_API.Services.Interfaces
{
    public interface IBUserService
    {
        public Result<List<BUserDTO>> GetAll();
        public Result<BUserDTO> GetById(long id);
        public BUser GetByEmail(string email);
        public Result<BUserDTO> CreateAccountForCurrentClient();
        public Result<List<BUserDTO>> GetCurrentClientAccounts();
        public Result<ProfileDTO> GetProfile( string email);
        public Result<RegisterRequestDTO> RegisterBUser(RegisterRequestDTO registerRequestDTO, UserManager<BUser> _userManager);
        public Result<UserProfileDTO> GetUserProfile(string email);
        public Result<bool> Subscribe(string userEmail);
    }
}
