using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " Eklendi");
                Console.WriteLine("****************************");
            }
            else
            {
                Console.WriteLine("Kimlik bilgileri doğrulanamadı!!!");
                Console.WriteLine("****************************");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Silindi");
            Console.WriteLine("****************************");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Güncellendi");
            Console.WriteLine("****************************");
        }
    }
}
