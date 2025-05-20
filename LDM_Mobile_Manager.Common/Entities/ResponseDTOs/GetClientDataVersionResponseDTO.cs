using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetClientDataVersionResponseDTO
    {
        [Required]
        public string Name{get; set;}

        [Required]
        public int Version { get; set; }

        [Required]
        public DateTime ModifiedAt { get; set; }

    }
}
