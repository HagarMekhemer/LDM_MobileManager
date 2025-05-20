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
        [Required]
        public string ArabicTitle { get; set; }

        [Required]
        public string EnglishTitle { get; set; }

        [Required]
        public string PromotionStartDate => StartDate.ToString("yyyy-MM-dd");

        [Required]
        public string PromotionEndDate => EndDate.ToString("yyyy-MM-dd");

        [JsonIgnore]
        public DateTime StartDate { get; set; }

        [JsonIgnore]
        public DateTime EndDate { get; set; }

        [Required]
        public bool AddPromotionToHome { get; set; }

        [Url]
        public string ContentUrl { get; set; }

        [Url]
        public string ContentAttachment { get; set; }

        public string ArabicContentText { get; set; }

        public string EnglishContentText { get; set; }
    }
}
