using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void EndOfMonthCampaign(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " için Ay Sonu Kampanyası Uygulanmıştır.");
        }

     
        public void NewYearCampaign(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " için Yeni Yıl Kampanyası Uygulanmıştır.");
        }
    }
}
