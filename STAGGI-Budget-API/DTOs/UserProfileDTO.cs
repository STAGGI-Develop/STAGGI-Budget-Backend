﻿using STAGGI_Budget_API.Models;
using System.Security.Principal;

namespace STAGGI_Budget_API.DTOs
{
    public class UserProfileDTO
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsPremium { get; set; } = false;
        public SubscriptionDTO? Subscription { get; set; }
    }
}
