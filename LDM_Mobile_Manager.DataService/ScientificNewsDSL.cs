using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class ScientificNewsDSL
    {
        private readonly ScientificNewsRepo _repo;

        public ScientificNewsDSL(ScientificNewsRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetScientificNewsResponseDTO>> GetScientificNews()
        {
            return await _repo.GetScientificNews();
        }
    }
}

