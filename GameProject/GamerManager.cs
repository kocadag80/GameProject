using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı kişi kaydedildi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı kişi silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı kişi güncellendi.");
        }
    }
}
