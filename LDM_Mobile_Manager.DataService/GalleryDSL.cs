using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService
{
    public class GalleryDSL
    {
        private readonly GalleryRepo _galleryRepo;

        public GalleryDSL(GalleryRepo galleryRepo)
        {
            _galleryRepo = galleryRepo;
        }

        public async Task<List<GetGalleryImageResponseDTO>> GetGalleryImages()
        {
            return await _galleryRepo.GetGalleryImages();
        }
    }
}
