﻿using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using STAGGI_Budget_API.DTOs;
using STAGGI_Budget_API.DTOs.Request;
using STAGGI_Budget_API.Helpers;
using STAGGI_Budget_API.Models;
using STAGGI_Budget_API.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace STAGGI_Budget_API.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<BUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthService(IConfiguration configuration, UserManager<BUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<string> CreateToken(BUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, $"{user.FirstName} {user.LastName}")
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(720),
                signingCredentials: credentials);

            var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

            return jwt;
        }

        public async Task<Result<string>> Login(RequestLoginDTO request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null || !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                return Result<string>.Unauthorized();
            }

            string token = await CreateToken(user);

            return Result<string>.Success(token);
        }

        public async Task<Result<string>> Register(RequestUserDTO request)
        {
            var userExists = await _userManager.FindByEmailAsync(request.Email);
            if (userExists != null)
            {
                var errorResponse = new ErrorResponseDTO
                {
                    Status = 403,
                    Error = "Forbid",
                    Message = "User already exists!",
                };
                return Result<string>.Failure(errorResponse);
            }

            BUser user = new()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.Email,
            };
            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                var errorResponse = new ErrorResponseDTO
                {
                    Status = 403,
                    Error = "Forbid",
                    Message = "User creation failed! Please check user details and try again.",
                };
                return Result<string>.Failure(errorResponse);
            }

            string token = await CreateToken(user);

            return Result<string>.Success(token);
        }

        public string ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var decodedToken = tokenHandler.ReadJwtToken(token);

            var emailClaim = decodedToken.Claims.FirstOrDefault(claim => claim.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");

            if (emailClaim != null)
            {
                var email = emailClaim.Value;
                return email;
            }
            else
            {
                return null;
            }
        }
    }
}
