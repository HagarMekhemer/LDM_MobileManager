using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class MobileUserProfileRepo : IBaseRepo<GetMobileUserProfileResponseDTO>
    {
        public async Task<List<GetMobileUserProfileResponseDTO>> GetAllAsync()
        {
            var profiles = new List<GetMobileUserProfileResponseDTO>
            {
                new GetMobileUserProfileResponseDTO
                {
                    ProfileName = "Patient",
                    ActivePages = new List<string> { "Services" }
                }
            };

            return await Task.FromResult(profiles);
        }
    }
}
    
