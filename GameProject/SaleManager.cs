using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleManager
    {
        public void CampaignSale(Game game)
        {
            Console.WriteLine("% "+game.CampDiscount+" indirim ile "+game.GameName+" satılmıştır.");
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun satılmıştır. ");
        }
    }
}
