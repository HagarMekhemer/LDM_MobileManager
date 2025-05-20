using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class GalleryRepo
    {
        public async Task<List<GetGalleryImageResponseDTO>> GetGalleryImages()
        {
            var images = new List<GetGalleryImageResponseDTO>
            {
                new GetGalleryImageResponseDTO { ImageURL = "http://example.com" }
            };

            return await Task.FromResult(images);
        }
    }
}
