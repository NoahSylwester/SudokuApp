using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Puzzle.Data;
using Puzzle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

namespace Puzzle.Pages
{
    public class IndexModel : PageModel
    {
        public char[,] puzzleMatrix;
        public char[,] solutionMatrix;
        public string puzzleString;

        public IndexModel()
        {
            var client = new RestClient("https://online-sudoku.p.rapidapi.com/random");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "online-sudoku.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "b7ece58cddmsh492adbb2d0e2f6fp19717djsnc1c02a305ff9");
            IRestResponse response = client.Execute(request);

            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            puzzleString = responseJson["item"];
            
            puzzleMatrix = new char[9,9];
            solutionMatrix = new char[9,9];
            System.Console.WriteLine(puzzleString);
            for (int i = 0; i < puzzleString.Length; i++ )
            {
                int y = i % 9;
                int x = i / 9;
                puzzleMatrix[x,y] = puzzleString[i];
                solutionMatrix[x,y] = puzzleString[i];
            }
            int numToHide = 40;
            for (int i = 0; i < numToHide; i++ )
            {
                Random random = new Random();
                int x = random.Next(0, 9);
                int y = random.Next(0, 9);

                puzzleMatrix[x,y] = '?';
            }
        }
        
        // public async Task<IActionResult> OnPostAsync(string solutionString)
        // {
        //     if (solutionString == puzzleString)
        //     {
        //         // Response.Clear();
        //         // Response.Write("Correct");
        //         Console.WriteLine(solutionString);
        //         Response.Write("successs");
        //     }
        //     else
        //     {
        //         // Response.Clear();
        //         // Response.Write("Incorrect");
        //         Console.WriteLine(solutionString);
        //         Response.Write("failure");
        //     }
        // }
    }
}