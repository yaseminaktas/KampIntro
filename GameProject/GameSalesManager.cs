using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameSalesManager
    {
        public void GameSale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+"oyunu"+ campaign.CampaignName+"kampanyasında satın aldınız");
        }
    }
}
