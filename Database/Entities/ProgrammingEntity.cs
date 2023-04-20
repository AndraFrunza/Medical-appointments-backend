using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class ProgrammingEntity : UserEntity
    {
        public string Hour { get; set; }
        public string Symptom { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public string DateOfBirth { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }

    }
}
