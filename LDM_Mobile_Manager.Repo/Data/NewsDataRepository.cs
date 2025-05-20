using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_MobileManager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class NewsDataRepository: IBaseRepository<GetNewsDataResponseDTO>
    {
        public async Task<List<GetNewsDataResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetNewsDataResponseDTO>
            {
                new GetNewsDataResponseDTO
                {
                    ArabicTitle = "عنوان عربي",
                    EnglishTitle = "English Title",
                    ContentUrl = "http://example.com"
                }
            });
        }
    }
}
