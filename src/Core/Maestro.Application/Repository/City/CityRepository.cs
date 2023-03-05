﻿using Maestro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.City
{
    public interface ICityRepository : IReadRepository<UT_City>, IWriteRepository<UT_City>
    {
    }
}
