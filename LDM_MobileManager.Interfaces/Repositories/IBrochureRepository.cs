using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Interfaces.Repositories
{
    public interface IBrochureRepository
    {
        Task<List<GetBrochuresResponseDTO>> GetBrochuresAsync();

    }
}
