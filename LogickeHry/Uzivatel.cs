namespace LogickeHry
{
    // Třída pro reprezentaci uživatele aplikace.
    internal class Uzivatel
    {
        // Konstruktor třídy Uzivatel, který nastaví nové ID uživatele.
        public Uzivatel()
        {
            Id = Guid.NewGuid(); // Vygeneruje nové GUID pro ID uživatele.
        }

        // Identifikátor uživatele.
        internal Guid Id { get; init; }

        // Jméno uživatele.
        internal string jmeno;

        // Hash hesla uživatele.
        internal string hashHesla;

        // Pohlaví uživatele.
        internal string pohlavi;

        // Věk uživatele.
        internal string vek;

        // Seznam SudokuZadani, která uživatel viděl.
        internal List<SudokuZadani> videl;
    }
}