using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void AddCampaing(Campaign campaign);

        void DeleteCampaign(Campaign campaign);

        void UpdateCampaign(Campaign campaign);
    }
}
