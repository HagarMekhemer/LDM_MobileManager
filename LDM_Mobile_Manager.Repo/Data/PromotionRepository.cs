using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class PromotionRepository: IBaseRepository<GetPromotionResponseDTO>
    {
        public async Task<List<GetPromotionResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetPromotionResponseDTO>
            {
                new GetPromotionResponseDTO
                {
                    ArabicTitle = "عرض خاص",
                    EnglishTitle = "Special Promotion",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 5, 10),
                    AddPromotionToHome = true,
                    ContentUrl = "http://example.com",
                    ContentAttachment = "http://example.com/attachment.pdf",
                    ArabicContentText = "تفاصيل العرض باللغة العربية",
                    EnglishContentText = "Promotion details in English"
                }
            });
        }
    }
}
