using Puzzle.Models;
using Microsoft.EntityFrameworkCore;
namespace Puzzle.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<PuzzleModel>().HasData(
                new PuzzleModel
                {
                    Id = 1,
                    Solved = true
                    // PuzzleMatrix = new int[,]{ {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9},
                    //                  {1,2,3,4,5,6,7,8,9} }
                }
            );
            return modelBuilder;
        }
    }
}