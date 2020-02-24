using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure.Configuration
{
    public class ItemConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> co)
        {
            co.HasKey(x => x.Id);
            co.Property(x => x.Name)
                .IsRequired();
            co.Property(x => x.PhoneNumber)
                .IsRequired();
            co.Property(x => x.Surname)
                .IsRequired();



        }
    }
}
