// Tato třída představuje kontext databáze pro práci s entitami pomocí Entity Framework Core.
using Microsoft.EntityFrameworkCore;

namespace LogickeHry;

// Třída DataContext dědí z DbContext, což je základní třída pro práci s Entity Framework Core.
internal class DataContext : DbContext
{
    // Metoda OnConfiguring je volána automaticky a konfiguruje databázové připojení.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Nastavení připojení k MySQL databázi pomocí UseMySQL metody a poskytnutí příslušných údajů.
        optionsBuilder.UseMySQL("server=api.strmilov.cz;database=aplikace;user=aplikace;password=[y/m2)9JSaRNEJ[");
    }
    // Metoda OnModelCreating je volána automaticky a konfiguruje vlastnosti a vztahy mezi entitami.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Konfigurace entity Uzivatel v databázi.
        modelBuilder.Entity<Uzivatel>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.jmeno).IsRequired();
            entity.Property(e => e.hashHesla).IsRequired();
            entity.Property(e => e.pohlavi).IsRequired();
            entity.Property(e => e.vek).IsRequired();
            entity.HasMany(e => e.videl).WithMany();
        });
        // Konfigurace entity SudokuZadani v databázi.
        modelBuilder.Entity<SudokuZadani>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.text).IsRequired();
            entity.Property(e => e.obtiznost).IsRequired();
        });
        // Konfigurace entity VysledekHry v databázi.
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
    // Vlastnost pro přístup k tabulce Uzivatele v databázi.
    public DbSet<Uzivatel>? Uzivatele { get; init; }

    // Vlastnost pro přístup k tabulce SudokuZadani v databázi.
    public DbSet<SudokuZadani>? Sudoku { get; init; }

    // Vlastnost pro přístup k tabulce VysledekHry v databázi.
    public DbSet<VysledekHry>? Statistiky { get; init; }
}