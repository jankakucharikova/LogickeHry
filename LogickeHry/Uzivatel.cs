namespace LogickeHry;

internal class Uzivatel
{
    public Uzivatel()
    {
        Id = Guid.NewGuid();
    }
    internal Guid Id { get; init; }
    internal string jmeno;
    internal string hashHesla;
    internal string pohlavi;
    internal string vek;
    internal List<SudokuZadani> videl;
}