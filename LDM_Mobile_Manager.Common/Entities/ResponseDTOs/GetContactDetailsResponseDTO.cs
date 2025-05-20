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
        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
