﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STAGGI_Budget_API.DTOs;
using STAGGI_Budget_API.DTOs.Request;
using STAGGI_Budget_API.Enums;
using STAGGI_Budget_API.Models;
using STAGGI_Budget_API.Repositories.Interfaces;
using STAGGI_Budget_API.Services;
using STAGGI_Budget_API.Services.Interfaces;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace STAGGI_Budget_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IAuthService _authService;
        public CategoriesController(ICategoryService categoryService, IAuthService authService)
        {
            _categoryService = categoryService;
            _authService = authService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = authorizationHeader?.Substring(7);
            var userEmail = _authService.ValidateToken(token);

            if (string.IsNullOrEmpty(userEmail))
            {
                return BadRequest("Email no encontrado.");
            }

            var result = _categoryService.GetByUserEmail(userEmail);
            if (!result.IsSuccess)
            {
                return StatusCode(result.Error.Status, result.Error);
            }
            return Ok(result.Ok);                       
        }

        [HttpGet("month")]
        public IActionResult GetMonth()
        {
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = authorizationHeader?.Substring(7);
            var userEmail = _authService.ValidateToken(token);

            if (string.IsNullOrEmpty(userEmail))
            {
                return BadRequest("Email no encontrado.");
            }

            var result = _categoryService.GetWithTransactions(userEmail, CategoryPeriod.MONTH);
            if (!result.IsSuccess)
            {
                return StatusCode(result.Error.Status, result.Error);
            }
            return Ok(result.Ok);
        }

        [HttpGet("week")]
        public IActionResult GetWeek()
        {
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = authorizationHeader?.Substring(7);
            var userEmail = _authService.ValidateToken(token);

            if (string.IsNullOrEmpty(userEmail))
            {
                return BadRequest("Email no encontrado.");
            }

            var result = _categoryService.GetWithTransactions(userEmail, CategoryPeriod.WEEK);
            if (!result.IsSuccess)
            {
                return StatusCode(result.Error.Status, result.Error);
            }
            return Ok(result.Ok);
        }

        [HttpPost]
        public IActionResult PostCategory(RequestCategoryDTO categoryDTO)
        {
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = authorizationHeader?.Substring(7);
            var userEmail = _authService.ValidateToken(token);

            if (string.IsNullOrEmpty(userEmail))
            {
                return BadRequest("Email no encontrado.");
            }

            var result = _categoryService.CreateCategory(categoryDTO, userEmail);
            if (!result.IsSuccess)
            {
                return StatusCode(result.Error.Status, result.Error);
            }
            return Ok(result.Ok);

        }

        [HttpPatch("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody]RequestCategoryDTO category)
        {
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = authorizationHeader?.Substring(7);
            var userEmail = _authService.ValidateToken(token);

            if (string.IsNullOrEmpty(userEmail))
            {
                return BadRequest("Email no encontrado.");
            }

            var result = _categoryService.UpdateCategory(id, category, userEmail);
            if (!result.IsSuccess)
            {
                return StatusCode(result.Error.Status, result.Error);
            }
            return Ok(result.Ok);
        }
    }
}
