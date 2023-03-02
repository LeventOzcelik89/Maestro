using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Maestro.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [DefaultValue("(newsequentialid())")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column(Order = 1, TypeName = "DATETIME")]
        [DefaultValue("GETDATE()")]
        public DateTime? Created { get; set; }

        [Column(Order = 2, TypeName = "DATETIME")]
        public DateTime? Changed { get; set; }

        [Column(Order = 3)]
        public Guid? CreatedId { get; set; }

        [Column(Order = 4)]
        public Guid? ChangedId { get; set; }

    }
}
