﻿using STAGGI_Budget_API.DTOs.Request;

namespace STAGGI_Budget_API.Data
{
    public class SampleData
    {
        public static List<RequestTransactionDTO> SampleTransactions()
        {
            return new List<RequestTransactionDTO>
            {
                new RequestTransactionDTO { Title = "Public Transport", Description = "Money for bus, metro and train transportation", Amount = -85, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Football Match", Description = "Ticket for Inter Miami game", Amount = -120, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Jacket", Description = "New jacket", Amount = -60, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Sport jersey", Description = "New Messi jersey from inter miami", Amount = -90, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Medic", Description = "Medic check up", Amount = -20, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Presents", Description = "Christmas", Amount = -137, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "A lamp", Description = "A new lamp for my bedroom", Amount = -17, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Computer", Description = "Gaming computer ", Amount = -1000, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "New videogame console", Description = "Play Station 5", Amount = -400, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Headache medication", Description = "Tablets", Amount = -22, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "New TV", Description = "Samsung QLED 65'", Amount = -200, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Elissir", Description = "Johnnie Walker Blue Label", Amount = -330, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Cinema", Description = "Tickets for the new batman movie", Amount = -15, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Bed", Description = "New king size bed", Amount = -200, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Car", Description = "New toyota corolla", Amount = -1000, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Tennis racket", Description = "A wilson tennis racket", Amount = -132, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Airplane tickets", Description = "Tickets to Madrid", Amount = -400, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Food", Description = "A hamburger from burger king", Amount = -5, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Shoes", Description = "New adidas shoes", Amount = -35, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Sofa", Description = "A new blue sofa", Amount = -53, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Birthday cake.", Description = "Birthday cake for Nacho.", Amount = -40, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Restaurant Dinner.", Description = "Birthday dinner on Jacksons.", Amount = -65, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Spiderman Suit.", Description = "Tom Holland Spiderman Suit.", Amount = -25, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Birthday Gift.", Description = "Birthday Gift for Nacho.", Amount = -100, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Uber.", Description = "Uber to home.", Amount = -30, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Dorm.", Description = "Bed sheets.", Amount = -50, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Weekly Grocery Shopping.", Description = "Weekly Groceries.", Amount = -200, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Streaming Service.", Description = "Monthly payment for Netflix and Youtube subscriptions.", Amount = -25, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Medical Expenses.", Description = "Flu medications.", Amount = -95, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Fitness Gym Membership.", Description = "Monthly membership fee for a fitness gym.", Amount = -50, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Home Shopping.", Description = "Cleaning products and supplies.", Amount = -40, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Pharmacy.", Description = "Cotton, Swabs, Shampoo.", Amount = -35, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Books.", Description = "Recipe books.", Amount = -25, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Jacket.", Description = "Brown jacket from Zara.", Amount = -150, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Technology Upgrade.", Description = "MacBook Air Laptop.", Amount = -1590, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Travel.", Description = "All inclusive in brazil.", Amount = -2200, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Travel needs.", Description = "Suitcase and Backpack.", Amount = -350, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Utility Bills.", Description = "Monthly payment for electricity, water, and other utilities.", Amount = -600, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Vehicle Maintenance.", Description = "Oil change and regular maintenance for the car.", Amount = -60, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Pet Care", Description = "Food and supplies.", Amount = -75, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Sneakers", Description = "Nike Air Max", Amount = -160, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Cinema", Description = "Tickets", Amount = -20, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Rent", Description = "Apartment", Amount = -190, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Brackets", Description = "Porcelain brackets", Amount = -140, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Jacket", Description = "Equus Black Jacket", Amount = -100, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Jersey", Description = "Adidas River Plate Home Jersey", Amount = -60, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Paint", Description = "Mona Lisa/ Gioconda (Replic)", Amount = -70, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Concert", Description = "The Weeknd ticket", Amount = -75, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Car", Description = "Ford Focus", Amount = -1000, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Speaker", Description = "Philco Speaker", Amount = -80, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Meet & Greet", Description = "Meet and Greet with Rodrigo Aliendro", Amount = -50, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Gym ", Description = "Gym monthly payment", Amount = -10, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Pyramid", Description = "Giza pyramid statue", Amount = -5, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Guitar", Description = "Stratocaster Green Parquer Ampli 5w.", Amount = -30, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Chair", Description = "Black chair (wood)", Amount = -13, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Jersey", Description = "Nike Portland Trailblazers new home Jersey", Amount = -99, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Watch", Description = "casio gold watch", Amount = -45, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Microwave ", Description = "Samsung Electronics Samsung MS19M8000AS/AA Large Capacity Countertop Microwave Oven with Sensor and Ceramic Enamel Interior, Stainless Steel, 1.9 cubic feet", Amount = -100, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Budget", Description = "Staggi budget monthly payment", Amount = -10, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Parfum", Description = "Pacco Rabbane Invictus", Amount = -100, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Birthday gift", Description = "Nacho's Birthday Gift", Amount = -2, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Monitor", Description = "Samsung Ultra Wide Monitor 49", Amount = -1600, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Rent", Description = "Monthly accommodation payment", Amount = -350, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Groceries", Description = "Food and household essentials", Amount = -150, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Utilities", Description = "Monthly bills for electricity, water, and other services", Amount = -80, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Insurance", Description = "Health Insurance", Amount = -100, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "AWS Course", Description = "Education IT Course on AWS", Amount = -45, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "SQL Course", Description = "Oracle Coruse on SQL (DBA carrer)", Amount = -75, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Date", Description = "Chocolate", Amount = -25, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Public transportation", Description = "Bus Card", Amount = -15, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Restaurant", Description = "Hotel stay & dinner", Amount = -220, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Travel", Description = "Rental car", Amount = -70, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Holiday Gifts", Description = "Souvenir gifts", Amount = -50, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Health Care", Description = "Doctor's Visit", Amount = -50, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Snacks", Description = "Snacks", Amount = -8, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Gym Membership", Description = "Gym monthly sub", Amount = -40, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Home Maintenance", Description = "Kitchen repairs", Amount = -60, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Dining Out", Description = "Fast Food - Burger King", Amount = -18, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Dental Health", Description = "Dental Check-up", Amount = -78, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Supermarket groceries", Description = "Vegetable foods ", Amount = -12, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Piano", Description = "Yamaha P45 88-Key Weighted Digital Piano", Amount = -599, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "RAM", Description = "Corsair Vengeance RGB PRO DDR4 32GB", Amount = -78, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Graphics card", Description = "GeForce RTX 4090", Amount = -1600, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Coffee machine", Description = "De'Longhi Stilosa Manual Espresso Machine", Amount = -109, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Laptop stand", Description = "Portable laptop stand for desk", Amount = -26, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Shoes", Description = "Nike Men's Air Max Fusion", Amount = -170, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Smart TV", Description = "Samsung Series 7 - 4K - 50", Amount = -650, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Supermarket", Description = "Weekly groceries", Amount = -140, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Bus", Description = "Bus fare", Amount = -2.7, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Cinema", Description = "Ticket and popcorn", Amount = -12.5, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Doctor", Description = "Visit to the cardiologist", Amount = -65, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Fast food", Description = "Fast food menu at Burger King", Amount = -8, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "T-shirts", Description = "Three t-shirts", Amount = -99, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Monitor", Description = "Acer Nitro 34 QHD 3440 x 1440", Amount = -309, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Smartphone", Description = "Samsung Galaxy S23 Ultra", Amount = -1000, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Videogame", Description = "Elden Ring for PC", Amount = -59, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Videogame", Description = "Red Dead Redemption for PC", Amount = -59, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Headphones", Description = "High quality headphones", Amount = -150, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Jeans", Description = "Blue jeans", Amount = -25, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Plants", Description = "Plants for decoration", Amount = -18, Type = 2, Category = "Home" },
                new RequestTransactionDTO { Title = "Clothes", Description = "Mountain Clothes for climbing expedition", Amount = -1000, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Helmet", Description = "MTB Helmet", Amount = -300, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Smart Watch", Description = "Garmin Solar Smart Watch", Amount = -800, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Groceries", Description = "Food and snaks for expedition", Amount = -50, Type = 2, Category = "Groceries" },
                new RequestTransactionDTO { Title = "Airline Tickets", Description = "Airline tickets to Italy", Amount = -1000, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Gas", Description = "Car Fuel", Amount = -300, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Shoes", Description = "La Sportiva Boots", Amount = -600, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "AWS", Description = "AWS Services fot thesis arquitecture", Amount = -500, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Phone Battery ", Description = "Phone Battery replacement", Amount = -70, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Tires", Description = "2x MTB Tires 29", Amount = -87, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Sube Credit", Description = "Sube Credit ", Amount = -35, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Rain Jacket", Description = "Acterix rain jacket", Amount = -400, Type = 2, Category = "Clothing" },
                new RequestTransactionDTO { Title = "Coliseo Tickets", Description = "Coliseo Tickets", Amount = -200, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Guided Expedition", Description = "Dolomite Guided Expedition", Amount = -1800, Type = 2, Category = "Entertainment" },
                new RequestTransactionDTO { Title = "Limone Hotel", Description = "Limone Hotel Reservation", Amount = -700, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Medicines", Description = "First Aid Medicines", Amount = -46, Type = 2, Category = "Health" },
                new RequestTransactionDTO { Title = "Train Tickets", Description = "Train tickets from Rome to Paris", Amount = -214, Type = 2, Category = "Transportation" },
                new RequestTransactionDTO { Title = "Head Lamp", Description = "Black Diamond Head Lamp 500lm", Amount = -149, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "Back Pack", Description = "Osprey Back Pack 75lt", Amount = -300, Type = 2, Category = "Miscellaneous" },
                new RequestTransactionDTO { Title = "FatMap", Description = "FatMap Subscription Plan", Amount = -100, Type = 2, Category = "Entertainment" }
            };
        }
    }
}
