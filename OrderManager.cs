using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void sale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("The game has been sold to the gamer: " + gamer.FirstName + gamer.LastName + 
                " with " + campaign.CampaingName+" with "+campaign.discountRate+" discount rate");
        }
    }
}
