﻿using Maestro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<SH_User> SH_User { get; set; }
    }
}
