using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetLabServicesResponseDTO
    {
        [Required(ErrorMessage = "The Arabic Title field is required.")]
        public string ArabicTitle { get; set; }
        [Required(ErrorMessage = "The English Title field is required.")]
        public string EnglishTitle { get; set; }
        public string MappedLISCode { get; set; }
        public string ArabicContentText { get; set; }
        public string EnglishContentText { get; set; }
    }
}
