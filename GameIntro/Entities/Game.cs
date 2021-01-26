using GameIntro.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Entities
{
    public class Game: IGameService
    {
        public string  GameName { get; set; }
        public int GamePrice { get; set; }

        public void Sell(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(game.GameName+" adlı oyunu "+user.FirstName+" "+user.LastName+" " +campaign.Name+"kampanyasından satın aldı." );
        }
    }
}
