using GameProject.Data;
using GameProject.Models;
using GameProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameProject.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly GameOperations gameOperations;
        private readonly AppDbContext appDbContext;
        public ResultsModel(GameOperations gameOperations,AppDbContext appDbContext)
        {
            this.gameOperations = gameOperations;
            this.appDbContext = appDbContext;
        }
        public String Result { get; set; }
        public Game GameResult { get; set; }    
        public IActionResult OnGet(int id)
        {
            GameResult = gameOperations.GetById(id);
            if(GameResult == null)
            {
                return NotFound();
            }
            if(GameResult.Number1 + GameResult.Number2 == 30)
            {
                GameResult.WonAmount = GameResult.Number1 * GameResult.Number2 * 2;
                Result = "Congratulations,You won" + GameResult.WonAmount;
            }
            else
            {
                Result = "You Lost! Try Again.";
            }
            appDbContext.SaveChanges();
            
            return Page();
        }
    }
}
