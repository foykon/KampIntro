using MyGameDemo.Abstract;
using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Concrete
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.Name + " : The Game Has Been Added Into Market !");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine(game.Name + " : The Game Has Been Deleted From Market !");
           
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " : The Game Has Been Updated !");
           
        }

    }
}
