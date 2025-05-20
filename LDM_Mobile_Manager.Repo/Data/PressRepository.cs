using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class PressRepository : IBaseRepository<GetPressResponseDTO>
    {
        public async Task<List<GetPressResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetPressResponseDTO>
            {
                new GetPressResponseDTO
                {
                    ArabicTitle = "تفاصيل العنوان العربي",
                    EnglishTitle = "English Title Details",
                    ContentUrl = "http://example.com/press-article"
                }
            });
        }
    }
}
