using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAllAsync();

    }
}
