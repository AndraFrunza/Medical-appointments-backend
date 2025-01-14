﻿using System.Collections.Generic;


namespace Database.Entities
{
    public class CabinetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DoctorEntity> Doctors { get; set; }
    }
}
