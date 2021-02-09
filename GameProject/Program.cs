using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.IdNumber = "12345678910";
            gamer1.GamerId = "1";
            gamer1.FirstName = "Ahmet";
            gamer1.LastName = "Kocadağ";
            gamer1.BirthYear = 1980;
            GamerManager gamerManager = new GamerManager();
            if (gamer1.IdNumber=="12345678910")
            {
                gamerManager.Add(gamer1);
            }
            else
            {
                Console.WriteLine("Bilgileriniz e-devlet bilgileriyle uyuşmuyor.");
            }
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game();
            game1.GameName = "GTA 5";
            game1.CampDiscount = 15;
            SaleManager saleManager = new SaleManager();
            saleManager.CampaignSale(game1);
            saleManager.Sale(game1);
            
        }
    }
}
