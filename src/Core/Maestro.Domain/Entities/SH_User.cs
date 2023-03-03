using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Domain.Entities
{
    public class SH_User : BaseEntity
    {
        [NotNull]
        public string FirstName { get; set; }
        
        [AllowNull]
        public string LastName { get; set; }


    }
}
