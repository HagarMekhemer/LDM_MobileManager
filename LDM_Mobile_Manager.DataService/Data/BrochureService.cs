using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_Mobile_Manager.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService.Data
{
    public class BrochureService : IBrochureService
    {
        private readonly IBrochureRepository _brochureRepository;

        public BrochureService(IBrochureRepository brochureRepository)
        {
            _brochureRepository = brochureRepository;
        }

        public async Task<ResponseDTO<List<GetBrochuresResponseDTO>>> GetBrochuresAsync()
        {
            var brochures = await _brochureRepository.GetBrochuresAsync();
            return new ResponseDTO<List<GetBrochuresResponseDTO>>(true, "Request Processed Successfully", brochures);
        }
    }
}
