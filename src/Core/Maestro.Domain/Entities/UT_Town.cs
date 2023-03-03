using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Domain.Entities
{
    public class UT_Town : BaseEntity
    {
        
        public Guid CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual UT_City UT_City { get; set; }
    }
}
