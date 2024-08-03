using System.ComponentModel.DataAnnotations;

namespace GameProject.Models
{
    public class ViewModel
    {
        [Required(ErrorMessage = "FullName is required.")]
        [Display(Name = "Your FullName:")]
        //[StringLength(20, ErrorMessage = "Max Length for name is {1}")]
        
        public string FullName { get; set; }

        [Required(ErrorMessage = "Number1 is required.")]
        [Display(Name = "Your First Number:")]
        public int Number1 { get; set; }

        [Required(ErrorMessage = "Number2 is required.")]
        [Display(Name = "Your Second Number:")]
        public int Number2 { get; set; }
    }
}
