using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class userValidationManager : IUserValidationService
    {
    
        public bool Validate(Player player)
        {
            if (player.FirstName == "Mert" && player.LastName == "Özdemir" && player.YearOfBirth==1986)
            {
                return true;
               
            }
            else
            {
                return false;
               
            }
        }
    }
}
