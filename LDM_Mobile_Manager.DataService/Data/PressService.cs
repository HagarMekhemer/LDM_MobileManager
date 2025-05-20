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
    public class PressService : IPressService
    {
        private readonly IPressRepository _pressRepository;

        public PressService(IPressRepository pressRepository)
        {
            _pressRepository = pressRepository;
        }

        public async Task<ResponseDTO<List<GetPressResponseDTO>>> GetPressAsync()
        {
            var pressItems = await _pressRepository.GetPressAsync();
            return new ResponseDTO<List<GetPressResponseDTO>>(true, "Request Processed Successfully", pressItems);
        }
    }
}
