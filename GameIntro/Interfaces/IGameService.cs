using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Interfaces
{
    interface IGameService
    {
        void Sell(Game game, User user, Campaign campaign);
    }
}
