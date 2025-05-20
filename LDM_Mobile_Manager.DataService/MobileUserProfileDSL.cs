using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class MobileUserProfileDSL
    {
        private readonly MobileUserProfileRepo _repo;

        public MobileUserProfileDSL(MobileUserProfileRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetMobileUserProfileResponseDTO>> GetMobileUserProfile()
        {
            return await _repo.GetMobileUserProfile();
        }
    }
}
