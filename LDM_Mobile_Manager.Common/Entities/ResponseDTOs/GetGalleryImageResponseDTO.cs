﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetGalleryImageResponseDTO
    {
        [Required(ErrorMessage = "The Image URL field is required.")]
        public string ImageURL { get; set; }
    }
}
