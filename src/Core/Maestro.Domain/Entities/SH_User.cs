﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Domain.Entities
{
    public class SH_User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
