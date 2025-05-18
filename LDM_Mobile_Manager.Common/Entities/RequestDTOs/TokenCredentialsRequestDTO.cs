using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.RequestDTOs
{
    public class TokenCredentialsRequestDTO
    {
        [Required(ErrorMessage = "The ClientCode field is required.")]
        public string ClientCode { get; set; }

        [Required(ErrorMessage = "The userName field is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password field is required.")]
        public string Password { get; set; }
    }
}
