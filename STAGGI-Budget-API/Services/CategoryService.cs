﻿using STAGGI_Budget_API.DTOs;
using STAGGI_Budget_API.Helpers;
using STAGGI_Budget_API.Repositories.Interfaces;

namespace STAGGI_Budget_API.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
         _categoryRepository = categoryRepository;
        }

        public Result <List<CategoryDTO>> GetAll() 
        {
            var result = _categoryRepository.GetAll();

            var categoriesDTO = new List<CategoryDTO>();
            foreach (var category in result)
            {
                categoriesDTO.Add(new CategoryDTO 
                {
                    Name = category.Name,
                    ImageUrl = category.ImageUrl,
                    TransactionsPerCategory= category.TransactionsPerCategory
                
                });
            }
            return Result<List<CategoryDTO>>.Success(categoriesDTO);
        }

        public Result<CategoryDTO> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Result<CategoryDTO> CreateCategoryForCurrentClient()
        {
            throw new NotImplementedException();
        }

        public Result<List<CategoryDTO>> GetCurrentClientCategory()
        {
            throw new NotImplementedException();
        }
    }
}