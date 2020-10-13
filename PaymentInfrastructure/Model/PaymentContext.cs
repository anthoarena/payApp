using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Model {
    public class PaymentContext : DbContext {

        public PaymentContext() { }
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8KPSGAI\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");//"Server=tcp:localhost,1433;Database=TestDB;User ID=sa;Password=Pa$$w0rd2019;"
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public  DbSet<Book> Books { get; set; }
        public  DbSet<Membership> Memberships { get; set; }
        public Member AddMember(Member member) {
            Members.Add(member);
            SaveChanges();
            return member;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>(entity => {
                entity.HasKey(e => e.MemberId);
                entity.Property(e => e.Firstname);
                entity.Property(e => e.Email);
                entity.Property(e => e.MembershipId);

            });

            modelBuilder.Entity<Member>().HasIndex(i => i.Email).IsUnique();

            modelBuilder.Entity<Payment>(entity => {
                entity.HasKey(e => e.PaymentId);
                entity.Property(e => e.MemberId);
                entity.Property(e => e.ProductType);
                entity.Property(e => e.ProductId);
                entity.Property(e => e.Amount);
            });

        }

    }

}