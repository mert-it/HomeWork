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
            if (game.Name == "PUBG")
            {
                game.UnitPrice = game.UnitPrice / 2;
                Console.WriteLine(player.FirstName + " " + player.LastName + ", " + game.Name + " oyununu " + game.UnitPrice + " TL bedelle satın aldı");
                
            }
            else
            {
                game.UnitPrice = game.UnitPrice / 4;
                Console.WriteLine(player.FirstName + " " + player.LastName + ", " + game.Name + " oyununu " + game.UnitPrice + " TL bedelle satın aldı");
                
            }
           Console.WriteLine(player.FirstName + " " + player.LastName + " için Yeni Yıl Kampanyası Uygulanmıştır.");
            Console.WriteLine("****************************");

        }
    }
}
