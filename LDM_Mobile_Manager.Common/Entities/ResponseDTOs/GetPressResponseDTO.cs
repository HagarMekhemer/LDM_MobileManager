using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetPressResponseDTO
    {
        [Required]
        public string ArabicTitle { get; set; }

        [Required]
        public string EnglishTitle { get; set; }

        [Required]
        [Url]
        public string ContentUrl { get; set; }
    }
}
