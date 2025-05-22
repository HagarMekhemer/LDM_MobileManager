using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetPromotionResponseDTO
    {
        [Required(ErrorMessage = "The Arabic Title field is required.")]

        public string ArabicTitle { get; set; }

        [Required(ErrorMessage = "The English Title field is required.")]
        public string EnglishTitle { get; set; }

        [Required(ErrorMessage = "The Promotion Start Date field is required.")]

        public string PromotionStartDate => StartDate.ToString("yyyy-MM-dd");

        [Required(ErrorMessage = "The Promotion EndDate field is required.")]

        public string PromotionEndDate => EndDate.ToString("yyyy-MM-dd");

        [JsonIgnore]
        public DateTime StartDate { get; set; }

        [JsonIgnore]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "The Add Promotion To Home field is required.")]

        public bool AddPromotionToHome { get; set; }

        [Url]
        public string ContentUrl { get; set; }

        [Url]
        public string ContentAttachment { get; set; }

        public string ArabicContentText { get; set; }

        public string EnglishContentText { get; set; }
    }
}
