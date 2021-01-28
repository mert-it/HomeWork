using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { FirstName = "Mert", LastName = "Özdemir", Id = 1, IdentityNumber = 123465789, YearOfBirth = 1985 };
            Player player2 = new Player { FirstName = "Ahmet", LastName = "Yıldız", Id = 2, IdentityNumber = 1234657890, YearOfBirth = 1985 };
            Game game1 = new Game { Id = 1, Name = "PUBG", UnitPrice= 250 };
            userValidationManager userValidationManager = new userValidationManager();
            GameSalesPlatformManager gameSalesPlatformManager = new GameSalesPlatformManager();
            CampaignManager campaignManager = new CampaignManager();
            PlayerManager playerManager = new PlayerManager();

            userValidationManager.Validation(player1);

            playerManager.Add(player1);
            playerManager.Delete(player2);
            playerManager.Update(player2);

            campaignManager.NewYearCampaign(player1 ,game1);


        }
    }
}
