using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SportsStoreApp.Models.Repository.RealDB;
using SportsStoreApp.Models;

namespace SportsStore.Models {
 public static class SeedData {
 public static void EnsurePopulated(IApplicationBuilder app) {
 ApplicationDbContext context = app.ApplicationServices
 .GetRequiredService<ApplicationDbContext>();
 context.Database.Migrate();
 if (!context.Products.Any()) {
 context.Products.AddRange(
 new Product {
 Name = "Kayak", Description = "A boat for one person",
CategoryID = 1, Price = 275 },
 new Product {
 Name = "Lifejacket",
Description = "Protective and fashionable",
CategoryID = 1, Price = 48.95m },
 new Product {
 Name = "Soccer Ball",
Description = "FIFA-approved size and weight",
CategoryID = 1, Price = 19.50m },
 new Product {
 Name = "Corner Flags",
Description = "Give your playing field a professional touch",
CategoryID = 1, Price = 34.95m },
 new Product {
 Name = "Stadium",
Description = "Flat-packed 35,000-seat stadium",
CategoryID = 1, Price = 79500 },
 new Product {
 Name = "Thinking Cap",
Description = "Improve brain efficiency by 75%",
CategoryID = 1, Price = 16 },
 new Product {
 Name = "Unsteady Chair",
Description = "Secretly give your opponent a disadvantage",
CategoryID = 1, Price = 29.95m },
 new Product {
 Name = "Human Chess Board",
Description = "A fun game for the family",
 CategoryID = 1, Price = 75 },
 new Product {
 Name = "Bling-Bling King",
Description = "Gold-plated, diamond-studded King",
CategoryID = 1, Price = 1200
 }
 );
 context.SaveChanges();
 }
 }
 }
 //bla bla
}