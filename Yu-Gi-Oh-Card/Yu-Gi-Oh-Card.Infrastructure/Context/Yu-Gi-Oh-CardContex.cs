using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Yu_Gi_Oh_Card.Domain.Entities;
using Yu_Gi_Oh_Card.Infrastructure.Mapping;

namespace Yu_Gi_Oh_Card.Infrastructure.Context
{
    public class Yu_Gi_Oh_CardContex : DbContext
    {
        public Yu_Gi_Oh_CardContex(DbContextOptions<Yu_Gi_Oh_CardContex> options) : base(options)
        {

        }

        public DbSet<Cards> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cards>(new CardsMap().Configure);
        }
    }
}
