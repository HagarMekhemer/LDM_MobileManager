using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.Exceptions
{
    public class NoContentException : ApplicationException
    {
        public NoContentException(string message = "No content available.") : base(message) { }
    }
}