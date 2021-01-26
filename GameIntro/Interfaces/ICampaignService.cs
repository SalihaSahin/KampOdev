using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Interfaces
{
   public interface ICampaignService
    {
        void Delete(Campaign campaign);
        void Add(Campaign campaign);
        void Update(Campaign campaign);
    }
}
