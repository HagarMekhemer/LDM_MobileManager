using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class ContactDetailsRepo
    {
        public async Task<List<GetContactDetailsResponseDTO>> GetContactDetails()
        {
            var data = new List<GetContactDetailsResponseDTO>
            {
                new GetContactDetailsResponseDTO
                {
                    IsActive = true,
                    Contact = "Facebook",
                    Value = "www.facebook.com/ldm"
                }
            };

            return await Task.FromResult(data);
        }
    }
}
