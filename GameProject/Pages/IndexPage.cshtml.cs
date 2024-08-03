using GameProject.Models;
using GameProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameProject.Pages
{
    public class IndexPageModel : PageModel
    {
        private readonly GameOperations gameOperations;
        public IndexPageModel (GameOperations gameOperations)
        {
            this.gameOperations = gameOperations;
        }

        [BindProperty]
        public BindingModel bindingModel { get; set; }
        public ViewModel viewModel { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPostInfo()
        {
            //Suppose we want to validate the route parameter
           
            if (bindingModel.Number1 <= 10 || bindingModel.Number1 >= 20 || bindingModel.Number2 <= 10 || bindingModel.Number2 >= 20)
            {
                ModelState.AddModelError("Validation of summation", "nb1 and nb2 should be between 10 and 20.");
                Console.WriteLine(string.Join(",", ModelState.Values.SelectMany(v => v.Errors).Select(x => x.ErrorMessage)));
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            int id = gameOperations.AddGame(bindingModel);
            return RedirectToPage("/Results", new {  id });
        }
    }
}
