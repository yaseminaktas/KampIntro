using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            {
                Id = 1, 
                BirthYear = 1985, 
                FirstName = "yasemin", 
                LastName = "aktaş" 
            });

            CampaignManager campaignManager = new CampaignManager();
            Campaign blackfriday = new Campaign();
            blackfriday.Id = 1;
            blackfriday.CampaignName = "black friday";
            blackfriday.CampaignDescription = "ıt is the biggest campaign";
            campaignManager.Add(blackfriday);

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.GameSale(new Gamer
            {
                Id = 2,
                FirstName="yyas",
                LastName="as",
                IdentityNumber=1223

            }, blackfriday);
        }
    }
}
