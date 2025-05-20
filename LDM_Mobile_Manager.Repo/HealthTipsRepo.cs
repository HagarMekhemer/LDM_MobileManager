using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class HealthTipsRepo
    {
        public async Task<List<GetHealthTipResponseDTO>> GetHealthTips()
        {
            // Simulated data
            var tips = new List<GetHealthTipResponseDTO>
            {
                new GetHealthTipResponseDTO
                {
                    ArabicTitle = "العنوان بالعربي",
                    EnglishTitle = "Title in English",
                    ContentUrl = "http://example.com",
                    ContentAttachment = "http://example.com",
                    ArabicContentText = "المحتوي بالعربي",
                    EnglishContentText = "English content"
                }
            };

            return await Task.FromResult(tips);
        }
    }
}



