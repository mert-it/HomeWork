using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class userValidationManager : IUserValidationService
    {
        //UserValidationManager _userValidationManager;

        public void Validation(Player player)
        {
            if (player.FirstName == "Mert" && player.LastName == "Özdemir")
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " için kimlik bilgileri doğrulandı.");
            }
            else
            {
                Console.WriteLine("Kimlik bilgileri doğrulanamadı");
            }
        }
    }
}
