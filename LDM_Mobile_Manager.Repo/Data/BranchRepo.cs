using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class BranchRepo : IBaseRepo<GetBranchesResponseDTO>
    {
        public async Task<List<GetBranchesResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetBranchesResponseDTO>
            {
                new GetBranchesResponseDTO
                {
                    ArabicTitle = "فرع القاهرة",
                    EnglishTitle = "Cairo Branch",
                    BranchCode = "CAI001",
                    BranchPhoneNumber = "+20212345678",
                    BranchArabicAddress = "١٢٣ شارع التحرير، القاهرة، مصر",
                    BranchEnglishAddress = "123 Tahrir Street, Cairo, Egypt",
                    BranchLocationLongitude = "31.2357",
                    BranchlocationLatitude = "24.713552"
                }
            });
        }
    }
}
