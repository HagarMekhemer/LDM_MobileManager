using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_MobileManager.Interfaces.Services
{
    public interface INewsDataService
    {
        Task<ResponseDTO<List<GetNewsDataResponseDTO>>> GetNewsDataAsync();
    }
}
