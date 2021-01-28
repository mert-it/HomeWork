﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
         
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Güncellendi");
        }
    }
}
