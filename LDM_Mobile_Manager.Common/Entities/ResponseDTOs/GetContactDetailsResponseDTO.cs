using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetContactDetailsResponseDTO
    {
        [Required(ErrorMessage = "The IsActive field is required.")]

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "The Contact field is required.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "The Value field is required.")]
        public string Value { get; set; }
    }
}
