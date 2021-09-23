using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Yu_Gi_Oh_Card.Domain.Entities;

namespace Yu_Gi_Oh_Card.Infrastructure.Mapping
{
    public class CardsMap : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.ToTable("Cards");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Description)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Description")
               .HasColumnType("varchar(255)");

            builder.Property(x => x.CreationUser)
                .IsRequired(false)
                .HasColumnType("int");

            builder.Property(x => x.UpdateUser)
                .IsRequired(false)
                .HasColumnType("int");

            builder.Property(x => x.CreationDate)
                .IsRequired();
            //.HasColumnType("CreationDate")
            //.HasDefaultValueSql("getdate()");

            builder.Property(x => x.UpdateDate)
                .IsRequired();
            //.HasColumnType("datetime")
            //.HasDefaultValueSql("getdate()");
        }

    }
}
