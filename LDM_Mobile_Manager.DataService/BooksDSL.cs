using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class BooksDSL
    {
        private readonly BooksRepo _repo;

        public BooksDSL(BooksRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<GetBookResponseDTO>> GetBooks()
        {
            return await _repo.GetBooks();
        }
    }
}

