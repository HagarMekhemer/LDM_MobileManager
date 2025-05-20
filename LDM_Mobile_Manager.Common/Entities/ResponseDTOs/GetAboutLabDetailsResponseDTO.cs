using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GetAboutLabDetailsResponseDTO
    {
        public string ArabicContentText { get; set; }
        public string EnglishContentText { get; set; }
        public string ArabicImageURL { get; set; }
        public string EnglishImageURL { get; set; }
    }
}
