using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class LabServicesRepo : IBaseRepo<GetLabServicesResponseDTO>
    {
        public async Task<List<GetLabServicesResponseDTO>> GetAllAsync()
        {
            var services = new List<GetLabServicesResponseDTO>
            {
                new GetLabServicesResponseDTO
                {
                    ArabicTitle = "Arabic Title Details",
                    EnglishTitle = "English Title Details",
                    MappedLISCode = "14512",
                    ArabicContentText = "Arabic Content Text",
                    EnglishContentText = "English Content Text"
                }
            };

            return await Task.FromResult(services);
        }
    }
}
