using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class ContactDetailsDSL
    {
        private readonly ContactDetailsRepo _repo;

        public ContactDetailsDSL(ContactDetailsRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetContactDetailsResponseDTO>> GetContactDetails()
        {
            return await _repo.GetContactDetails();
        }
    }
}
