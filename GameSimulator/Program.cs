using GameSimulator.Concrete;
using GameSimulator.Entities;
using System;

namespace GameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player(1, "321321321", "Yasemin", "Aktaş", 1999);
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Save(NewPlayer1);

            Game NewGame1 = new Game();
            NewGame1.Name = "aa";
            NewGame1.Price = 100;

            Campaign newCampaign = new Campaign();
            newCampaign.Name = "fırsatlar";
            newCampaign.Content = "indirim";

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(NewPlayer1, NewGame1);

            salesManager.Buy2(NewPlayer1, NewGame1, newCampaign);

            Console.ReadLine();

        }
    }
}
