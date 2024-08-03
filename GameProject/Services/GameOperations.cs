using GameProject.Data;
using GameProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GameProject.Services
{
    public class GameOperations
    {
        public readonly AppDbContext _context;
        public GameOperations(AppDbContext context) 
        {
            _context = context;
        }
        public int AddGame(BindingModel bindingModel)
        {
            var game = new Game()
            {
                FullName = bindingModel.FullName,
                Number1 = bindingModel.Number1,
                Number2 = bindingModel.Number2,
                WonAmount = -1
               
            };
            _context.Games.Add(game);
            _context.SaveChanges();
            return game.IdGame;
        }
        public Game GetById(int Id)
        {
            Game game = _context.Games.FirstOrDefault(x=>x.IdGame == Id);
            if (game == null)
            {
                game = new Game() { IdGame = -2, FullName = "not found"};
            }
            return game;

        }
        public List<Game> GetGames()
        {
            return _context.Games.Where(x=>x.WonAmount != -1).ToList();
        }



    }
}
