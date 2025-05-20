using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class ClientDataVersionDSL
    {
        private readonly ClientDataVersionRepo _repo;

        public ClientDataVersionDSL(ClientDataVersionRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetClientDataVersionResponseDTO>> GetClientDataVersions()
        {
            return await _repo.GetClientDataVersions();
        }
    }
}


