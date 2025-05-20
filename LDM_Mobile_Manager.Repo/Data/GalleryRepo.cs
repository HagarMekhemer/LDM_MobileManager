using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class GalleryRepo : IBaseRepo<GetGalleryImageResponseDTO>
    {
        public async Task<List<GetGalleryImageResponseDTO>> GetAllAsync()
        {
            var images = new List<GetGalleryImageResponseDTO>
            {
                new GetGalleryImageResponseDTO { ImageURL = "http://example.com" }
            };

            return await Task.FromResult(images);
        }
    }
}
