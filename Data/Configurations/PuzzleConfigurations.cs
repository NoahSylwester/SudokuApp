using Puzzle.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Puzzle.Data.Configurations
{
    public class PuzzleConfiguration : IEntityTypeConfiguration<PuzzleModel>
    {
        public void Configure(EntityTypeBuilder<PuzzleModel> builder)
        {
            builder.Property(p => p.Solved).HasColumnName("Solved");;
        }
    }
}