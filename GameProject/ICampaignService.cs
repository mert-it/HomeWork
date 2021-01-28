using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService 
    {
        void NewYearCampaign(Player player, Game game);

        void EndOfMonthCampaign(Player player, Game game);
    }
}
