using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Interfaces.Services
{
    public interface IPromotionService
    {
        Task<ResponseDTO<List<GetPromotionResponseDTO>>> GetPromotionsAsync();
    }
}
