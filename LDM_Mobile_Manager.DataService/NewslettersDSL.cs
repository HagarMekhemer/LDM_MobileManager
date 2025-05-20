using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class NewslettersDSL
    {
        private readonly NewslettersRepo _repo;

        public NewslettersDSL(NewslettersRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetNewsletterResponseDTO>> GetNewsletters()
        {
            return await _repo.GetNewsletters();
        }
    }
}
