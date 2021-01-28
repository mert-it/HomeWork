using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSalesPlatformManager : IGameSalesPlatformService
    {
        public void Sale(Player player, Game game)
        {
          Console.WriteLine(player.FirstName +" " + player.LastName + ", " + game.Name + " oyununu " + game.UnitPrice + " TL bedelle satın aldı");
            Console.WriteLine("****************************");
        }
    }
}
