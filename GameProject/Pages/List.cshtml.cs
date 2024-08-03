using GameProject.Models;
using GameProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameProject.Pages
{
    public class ListModel : PageModel
    {
        private readonly GameOperations _gameOperations;
        public ListModel(GameOperations gameOperations)
        {
            _gameOperations = gameOperations;
        }
        public List<Game> Games { get; set; }   
        public IActionResult OnGet()
        {
            Games = _gameOperations.GetGames();
            return Page();
        }

    }
}
