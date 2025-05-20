using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Interfaces.Repositories
{
    public interface IPressRepository
    {
        Task<List<GetPressResponseDTO>> GetPressAsync();
    }
}
