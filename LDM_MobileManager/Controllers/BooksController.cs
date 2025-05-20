using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using LDM_Mobile_Manager.DSL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class BooksController : ControllerBase
    {
        private readonly BooksDSL _dsl;

        public BooksController(BooksDSL dsl)
        {
            _dsl = dsl;
        }

        [HttpGet("GetBooks")]
        public async Task<ActionResult<ResponseDTO<List<GetBookResponseDTO>>>> GetBooks()
        {
            var data = await _dsl.GetBooks();
            return Ok(new ResponseDTO<List<GetBookResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}

