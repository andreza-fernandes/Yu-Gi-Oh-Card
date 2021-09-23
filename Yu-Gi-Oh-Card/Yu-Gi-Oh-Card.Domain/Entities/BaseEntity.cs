using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yu_Gi_Oh_Card.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? CreationUser { get; set; }
        public int? UpdateUser { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
