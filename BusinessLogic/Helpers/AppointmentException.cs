using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
  public class AppointmentException : Exception
    {
       public AppointmentException()
        {

        }

        public AppointmentException(string message) : base(message)
        {
           
        }
    }
}
