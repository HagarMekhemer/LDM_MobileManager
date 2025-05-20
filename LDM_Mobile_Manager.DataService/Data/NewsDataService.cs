using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_MobileManager.Interfaces.Repositories;
using LDM_MobileManager.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService.Data
{
    public class NewsDataService : INewsDataService
    {
        private readonly INewsDataRepository _newsDataRepository;

        public NewsDataService(INewsDataRepository newsRepository)
        {
            _newsDataRepository = newsRepository;
        }

        public async Task<ResponseDTO<List<GetNewsDataResponseDTO>>> GetNewsDataAsync()
        {
            var newsItems = await _newsDataRepository.GetNewsAsync();

            if (newsItems == null || !newsItems.Any())
            {
                return new ResponseDTO<List<GetNewsDataResponseDTO>>(true, "No news available", new List<GetNewsDataResponseDTO>());
            }

            return new ResponseDTO<List<GetNewsDataResponseDTO>>(true, "Request Processed Successfully", newsItems);
        }
    }
}
