using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
