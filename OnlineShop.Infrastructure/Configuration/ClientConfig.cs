using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> cl)
        {
            cl.HasKey(x => x.Id);

            cl.Property(x => x.Name)
                .IsRequired();
            cl.Property(x => x.PhoneNumber)
                .IsRequired();
            cl.Property(x => x.Surname)
                .IsRequired();
        }
    }
}
