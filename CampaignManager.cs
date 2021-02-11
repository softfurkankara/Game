using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaing(Campaign campaign)
        {
            Console.WriteLine("new campaign is defined to User discount Rate is:  "+campaign.discountRate);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("new Campaing is updated to gamer is updated. Discount rate is :"+campaign.discountRate);
        }
    }
}
