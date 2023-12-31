﻿using STAGGI_Budget_API.DTOs;
using STAGGI_Budget_API.DTOs.Request;
using STAGGI_Budget_API.Enums;
using STAGGI_Budget_API.Helpers;
using STAGGI_Budget_API.Models;

namespace STAGGI_Budget_API.Services.Interfaces
{
    public interface IBudgetService
    {
        
        public Result<List<BudgetDTO>> GetAllByEmail(string email);
        public Result<BudgetDTO> GetById(int id);
        public Result<string> CreateBudget(RequestBudgetDTO budgetDTO, string email);
        public Result<BudgetDTO> UpdateBudget(int budgetId, RequestBudgetDTO updatedBudgetDTO, string email);
        void UpdateBudgetBalance(int budgetId);
    }
}
