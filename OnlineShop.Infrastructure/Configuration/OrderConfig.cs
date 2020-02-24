using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure.Configuration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> or)
        {
            or
                .HasKey(x => x.Id);

            or
                .Property(x => x.DoneDate)
                .IsRequired();

            or
                .Property(x => x.OrderDate)
                .IsRequired();

            or
                .HasOne(x => x.Client)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ClientID);




        }
    }
}
