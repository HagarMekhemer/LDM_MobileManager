using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetClientDataVersionResponseDTO
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name{get; set;}

        [Required(ErrorMessage = "The Version field is required.")]
        public int Version { get; set; }

        [Required(ErrorMessage = "The Modified At field is required.")]
        public DateTime ModifiedAt { get; set; }

    }
}
