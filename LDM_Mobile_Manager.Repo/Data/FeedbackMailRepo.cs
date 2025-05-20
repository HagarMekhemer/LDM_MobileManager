using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo.Data
{
    public class FeedbackMailRepo : IBaseRepo<GetFeedbackMailResponseDTO>
    {
        public async Task<List<GetFeedbackMailResponseDTO>> GetAllAsync()
        {
            return await Task.FromResult(new List<GetFeedbackMailResponseDTO>
            {
                new GetFeedbackMailResponseDTO
                {
                    FeedbackMail = "user@example.com"
                }
            });
        }
    }
}
