using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class NewslettersRepo : IBaseRepo<GetNewsletterResponseDTO>
    {
        public async Task<List<GetNewsletterResponseDTO>> GetAllAsync()
        {
            // Mock Data
            var newsletters = new List<GetNewsletterResponseDTO>
            {
                new GetNewsletterResponseDTO
                {
                    ArabicTitle = "عنوان النشرة",
                    EnglishTitle = "Newsletter Title",
                    ContentAttachment = "http://example.com"
                }
            };

            return await Task.FromResult(newsletters);
        }
    }
}