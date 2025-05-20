using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetBranchesResponseDTO
    {
        [Required]
        public string ArabicTitle { get; set; }

        [Required]
        public string EnglishTitle { get; set; }

        [Required]
        public string BranchCode { get; set; }

        public string BranchPhoneNumber { get; set; }

        public string BranchArabicAddress { get; set; }

        public string BranchEnglishAddress { get; set; }

        public string BranchLocationLongitude { get; set; }

        public string BranchlocationLatitude { get; set; }
    }
}
