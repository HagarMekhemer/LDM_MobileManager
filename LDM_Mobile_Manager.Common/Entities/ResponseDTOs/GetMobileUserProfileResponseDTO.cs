using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetMobileUserProfileResponseDTO
    {
        [Required]
        public string ProfileName { get; set; }

        [Required]
        public List<string> ActivePages { get; set; }
    }
}
