using Microsoft.EntityFrameworkCore;

namespace LogickeHry;

internal class DataContext : DbContext
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
            entity.Property(e => e.jmeno).IsRequired();
            entity.Property(e => e.hashHesla).IsRequired();
            entity.Property(e => e.pohlavi).IsRequired();
            entity.Property(e => e.vek).IsRequired();
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
            entity.Property(e => e.skore).IsRequired();
            entity.Property(e => e.datum).IsRequired();
        });
    }
    public DbSet<Uzivatel>? Uzivatele { get; init; }
    public DbSet<SudokuZadani>? Sudoku { get; init; }

    public DbSet<VysledekHry>? Statistiky { get; init; }
}