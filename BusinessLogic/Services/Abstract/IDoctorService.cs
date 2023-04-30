﻿using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Abstract
{
   public interface IDoctorService : IService<DoctorDto>
    {
        RoleDto GetBySpecialization(string specialization);
    }
}
