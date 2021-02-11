using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            Gamer gamer = new Gamer();
            gamerManager.Add(new Gamer {
                Id = 1, BirthYear = 1998,
                FirstName = "Furkan", 
                LastName = "Kara", 
                IdentityNumber = 12345 });

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.discountRate = 0.2;
            campaign.CampaingName = "New Gamer discount";

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.sale(gamer, campaign);
        }
    }
}
