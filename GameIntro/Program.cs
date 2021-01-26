using GameIntro.Entities;
using GameIntro.Interfaces;
using System;

namespace GameIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { FirstName = "Saliha", LastName = "Şahin", Id = 1, DateOfBirth = new DateTime(2000, 10, 4) };
            IUserManager userManager = new UserManager(new UserCheckManager());
            userManager.Save(user1);
            userManager.Update(user1);
            userManager.Delete(user1);

            Console.WriteLine("***********************************");
           
            ICampaignService campaignService = new Campaign();
            Campaign campaign1 = new Campaign { Id = 1, Name = "Ramazan " };
            campaignService.Add(campaign1);
            campaignService.Delete(campaign1);
            campaignService.Update(campaign1);

            Console.WriteLine("************************************");

            Game game = new Game();
            game.GameName = "SIMS";
            game.GamePrice = 120;
            IGameService gameService = new Game();
            gameService.Sell(game, user1, campaign1);

        }
    }
}
