using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using OnlineShop.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Infrastructure
{
    public class Context: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder fluent)
        {
            fluent.Entity<Item>(ItemConfig);

            fluent.Entity<Cart>(CartConfig);

            fluent.Entity<Order>(OrderConfig);

            fluent.Entity<Client>(ClientConfig);
        }
        public void ItemConfig(EntityTypeBuilder<Item> pfluent)
        {
            pfluent.HasKey(i => i.Id);
            pfluent.HasIndex(i => i.Id).IsUnique();
            pfluent.Property(i => i.Id).IsRequired();
            pfluent.Property(i => i.Id).HasColumnType("int");
            pfluent.HasIndex(i => i.CartId).IsUnique();
            pfluent.Property(i => i.CartId).IsRequired();

            //pfluent.HasOne(ca => ca.Cart)
            //    .WithMany(i => i.Item)
            //    .HasForeignKey(i => i.CartId);

        }
        public void CartConfig(EntityTypeBuilder<Cart> cfluent)
        {
            cfluent.HasIndex(ca => new { ca.Id, ca.OrderId }).IsUnique();
            cfluent.HasKey(ca => ca.Id);
            cfluent.Property(ca => ca.Id).IsRequired();
            cfluent.Property(ca => ca.OrderId ).IsRequired();
            cfluent.Property(ca => ca.Id).HasColumnType("int");
            cfluent.Property(ca => ca.OrderId ).HasColumnType("int");

            //cfluent.HasOne(o => o.Order)
            //    .WithOne(ca => ca.Cart);


        }
        public void OrderConfig(EntityTypeBuilder<Order> ofluent)
        {
            ofluent.HasKey(o => o.Id);
            ofluent.HasIndex(o => new { o.Id, o.ClientID }).IsUnique();
            ofluent.Property(o => o.Id).IsRequired();
            ofluent.Property(o => o.ClientID ).IsRequired();
            ofluent.Property(o => o.Id).HasColumnType("int");
            ofluent.Property(o => o.ClientID ).HasColumnType("int");

            ofluent.HasOne(c => c.Client)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.ClientID);
        }
        public void ClientConfig(EntityTypeBuilder<Client> cfluent)
        {
            cfluent.HasIndex(c => c.Id).IsUnique();
            cfluent.HasKey(c => c.Id);
            cfluent.Property(c => c.Id).IsRequired();
            cfluent.Property(c => c.Id).HasColumnType("int");
        }

    }
}
