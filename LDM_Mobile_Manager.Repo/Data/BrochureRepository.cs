using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class BrochureRepository : IBaseRepository<GetBrochuresResponseDTO>
    {
        public async Task<List<GetBrochuresResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetBrochuresResponseDTO>
            {
                new GetBrochuresResponseDTO
                {
                    ArabicTitle = "تفاصيل العنوان العربي",
                    EnglishTitle = "English Title Details",
                    ContentAttachment = "http://example.com/brochure.pdf"
                }
            });
        }
    }
}
