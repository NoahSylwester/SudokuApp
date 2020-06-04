using Puzzle.Models;
using Microsoft.EntityFrameworkCore;
using Puzzle.Data.Configurations;

namespace Puzzle.Data
{
    public class PuzzleContext : DbContext
    {
        public DbSet<PuzzleModel> Puzzles { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Puzzle.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PuzzleConfiguration()).Seed();
        }
    }
}