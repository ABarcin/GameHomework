using GameHomework.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public string GamePlatform { get; set; }
        public double Price { get; set; }
    }
}
