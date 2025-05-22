using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.Exceptions
{
    public class CustomResponseValidationException : ApplicationException
    {
        public CustomResponseValidationException(string message) : base(message) { }
    }
}
