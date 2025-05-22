using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.Exceptions
{
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException(string message = "Not authorized") : base(message) { }
    }

}
