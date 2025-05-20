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
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;

        public PromotionService(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }

        public async Task<ResponseDTO<List<GetPromotionResponseDTO>>> GetPromotionsAsync()
        {
            var promotions = await _promotionRepository.GetPromotionsAsync();

            if (promotions == null || !promotions.Any())
            {
                return new ResponseDTO<List<GetPromotionResponseDTO>>(true, "No promotions available", new List<GetPromotionResponseDTO>());
            }

            return new ResponseDTO<List<GetPromotionResponseDTO>>(true, "Request Processed Successfully", promotions);
        }
    }
}
