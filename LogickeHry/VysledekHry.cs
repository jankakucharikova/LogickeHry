namespace LogickeHry
{
    // Třída pro reprezentaci výsledku hry.
    internal class VysledekHry
    {
        // Identifikátor výsledku hry.
        internal Guid Id { get; init; } = Guid.NewGuid();

        // Uživatel, který dosáhl výsledku.
        internal Uzivatel uzivatel;

        // Název hry, ke které se výsledek vztahuje.
        internal string hra;

        // Obtížnost, ve které byla hra dokončena.
        internal string obtiznost;

        // Čas strávený při hře.
        internal int cas;

        // Dosáhnuté skóre v hře.
        internal int skore;

        // Datum, kdy byla hra dokončena.
        internal DateTime datum;
    }
}