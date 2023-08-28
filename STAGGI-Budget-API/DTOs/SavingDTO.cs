﻿using System.ComponentModel.DataAnnotations.Schema;

namespace STAGGI_Budget_API.DTOs
{
    public class SavingDTO
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double TargetAmount { get; set; }
        public DateTime? DueDate { get; set; }
    }
}