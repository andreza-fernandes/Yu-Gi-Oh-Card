using System;
using System.Collections.Generic;
using System.Text;

namespace Yu_Gi_Oh_Card.Domain.Entities
{
    public class Cards : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        //public string Attack { get; set; }
        //public string Defense { get; set; }
        //public string Effect { get; set; }
        //public string MonsterType { get; set; }
        //public string CardType { get; set; }
    }
}
