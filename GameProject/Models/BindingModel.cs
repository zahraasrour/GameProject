using GameProject.Migrations;
using System.ComponentModel.DataAnnotations;

namespace GameProject.Models
{
    public class BindingModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public int Number1 { get; set; }

        [Required]
        public int Number2 { get; set; }
    }
}
