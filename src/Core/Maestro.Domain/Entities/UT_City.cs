using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Maestro.Domain.Entities
{
    public class UT_City : BaseEntity
    {
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        public virtual ICollection<UT_Town> UT_Towns { get; set; }
    }
}
