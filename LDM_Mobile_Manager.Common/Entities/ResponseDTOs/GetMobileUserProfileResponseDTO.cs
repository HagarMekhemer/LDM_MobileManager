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
        [Required(ErrorMessage = "The Profile Name field is required.")]
        public string ProfileName { get; set; }

        [Required(ErrorMessage = "The Active Pages field is required.")]
        public List<string> ActivePages { get; set; }
    }
}
