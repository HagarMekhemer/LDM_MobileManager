using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_MobileManager.Interfaces.Repositories
{
    public interface INewsDataRepository
    {
        Task<List<GetNewsDataResponseDTO>> GetNewsAsync();
    }
}
