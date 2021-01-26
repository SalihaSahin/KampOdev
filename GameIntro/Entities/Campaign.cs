using GameIntro.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Entities
{
    public class Campaign:ICampaignService
    {
        public string Name { get; set; }
        public int Id { get; set; }
       

        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" adlı kampanya listeye eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya listeden silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya güncellendi.");
        }
    }
}
