using System.ComponentModel.DataAnnotations;

namespace GameProject.Models
{
    public class Game
    {
        [Key]
        public int  IdGame { get; set; }
        public string FullName { get; set; } 
        public  int Number1{ get; set; }
        public int Number2 { get; set; }
        public int WonAmount { get; set; }
    }
}
