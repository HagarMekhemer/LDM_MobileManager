using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LDM_Mobile_Manager.DataService
{
    public class HealthTipsDSL
    {
        private readonly HealthTipsRepo _healthTipsRepo;

        public HealthTipsDSL(HealthTipsRepo healthTipsRepo)
        {
            _healthTipsRepo = healthTipsRepo;
        }

        public async Task<List<GetHealthTipResponseDTO>> GetHealthTips()
        {
            return await _healthTipsRepo.GetHealthTips();
        }
    }
}
