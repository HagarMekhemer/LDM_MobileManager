using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class BooksRepo : IBaseRepo<GetBookResponseDTO>
    {

        public async Task<List<GetBookResponseDTO>> GetAllAsync()
        {
            var books = new List<GetBookResponseDTO>
            {
                new GetBookResponseDTO
                {
                    ArabicTitle = "العنوان بالعربي",
                    EnglishTitle = "English Book Title",
                    ContentAttachment = "http://example.com"
                }
            };

            return await Task.FromResult(books);
        }
    }
}
