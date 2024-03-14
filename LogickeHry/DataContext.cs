using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=api.strmilov.cz;database=aplikace;user=aplikace;password=[y/m2)9JSaRNEJ[");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Uzivatel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Jmeno).IsRequired();
                entity.Property(e => e.HashHesla).IsRequired();
                entity.Property(e => e.Pohlavi).IsRequired();
                entity.Property(e => e.Vek).IsRequired();
                entity.HasMany(e => e.videl).WithMany();
            });
            modelBuilder.Entity<SudokuZadani>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.text).IsRequired();
                entity.Property(e => e.obtiznost).IsRequired();
            });
            modelBuilder.Entity<VysledekHry>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.uzivatel).WithMany().IsRequired();
                entity.Property(e => e.hra).IsRequired();
                entity.Property(e => e.obtiznost).IsRequired();
                entity.Property(e => e.cas).IsRequired();
                entity.Property(e=> e.skore).IsRequired();
                entity.Property(e=>e.datum).IsRequired();
            });
        }
        public DbSet<Uzivatel> uzivatele { get; set; }
        public DbSet<SudokuZadani> sudoku { get; set; }

        public DbSet<VysledekHry> statistiky { get; set; }
    }
}
