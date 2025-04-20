// Title: AppDbContext.cs
// Author: Ahmed Ibrahim
// Date: 2025-04-15
// Description: EF Core DbContext for the Layered Architecture Book Management System.

// Ignore Spelling: App

using Microsoft.EntityFrameworkCore;
using MiniRentalSystem.Domain.Entities;

namespace MiniRentalSystem.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books => Set<Book>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent configurations (optional for now)
        }
    }
}