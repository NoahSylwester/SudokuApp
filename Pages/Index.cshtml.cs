using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Puzzle.Data;
using Puzzle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace Puzzle.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PuzzleContext db;  
        public IndexModel(PuzzleContext db) => this.db = db;
        public List<PuzzleModel> SolvedPuzzles { get; set; } = new List<PuzzleModel>();  
        public PuzzleModel FeaturedPuzzle { get; set; }  
        public async Task OnGetAsync()
        {
            SolvedPuzzles = await db.Puzzles.ToListAsync();
            FeaturedPuzzle = SolvedPuzzles.ElementAt(new Random().Next(SolvedPuzzles.Count));
        }
    }
}