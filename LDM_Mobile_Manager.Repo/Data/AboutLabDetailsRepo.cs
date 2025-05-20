using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class AboutLabDetailsRepo : IBaseRepo<GetAboutLabDetailsResponseDTO>
    {
        public async Task<List<GetAboutLabDetailsResponseDTO>> GetAllAsync()
        {
            var aboutLab = new List<GetAboutLabDetailsResponseDTO>
            {
                new GetAboutLabDetailsResponseDTO
                {
                     ArabicContentText = "Arabic Content Text",
                     EnglishContentText = "English Content Text",
                     ArabicImageURL = "http://example.com",
                     EnglishImageURL = "http://example.com"
                }
            };

            return await Task.FromResult(aboutLab);
        }
    }
}
