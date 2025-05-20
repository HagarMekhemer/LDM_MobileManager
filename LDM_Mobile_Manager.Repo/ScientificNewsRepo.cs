using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class ScientificNewsRepo
    {
        public async Task<List<GetScientificNewsResponseDTO>> GetScientificNews()
        {
            // Mock data
            var news = new List<GetScientificNewsResponseDTO>
            {
                new GetScientificNewsResponseDTO
                {
                    ArabicTitle = "عنوان النشرة العلمي",
                    EnglishTitle = "Scientific News Title",
                    ArabicContentText = "المحتوي بالعربي",
                    EnglishContentText = "English content text"
                }
            };

            return await Task.FromResult(news);
        }
    }
}
