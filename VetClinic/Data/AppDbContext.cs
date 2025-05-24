using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetClinic.Models;

namespace VetClinic.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Wizyta> Wizyty {  get; set; }
        public DbSet<Osoba> Osoby {  get; set; }
        public DbSet<Lekarz> Lekarze { get; set; }
        public DbSet<Zwierze> Zwierzeta { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Lek> Leki { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wizyta>()
            .HasMany(w => w.Leki)
            .WithMany(l => l.Wizyty)
            .UsingEntity<Dictionary<string, object>>(
                "WizytaLek",
                j => j.HasOne<Lek>().WithMany().HasForeignKey("LekId"),
                j => j.HasOne<Wizyta>().WithMany().HasForeignKey("WizytaId"),
                j => j.ToTable("WizytaLek"));

            modelBuilder.Entity<Wizyta>()
            .Property(w => w.Data)
            .HasColumnType("date");

            modelBuilder.Entity<Wizyta>()
           .HasOne(w => w.Zwierze)
           .WithMany()
           .HasForeignKey(w => w.ZwierzeId)
           .OnDelete(DeleteBehavior.SetNull);
            }

    }
}
