using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class MyGameGameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" Oyunu Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Düzenlendi.");
        }
    }
}
