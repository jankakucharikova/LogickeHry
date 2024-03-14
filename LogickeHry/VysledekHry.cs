namespace LogickeHry;

internal class VysledekHry
{

    internal Guid Id { get; init; } = Guid.NewGuid();
    internal Uzivatel uzivatel;
    internal string hra;
    internal string obtiznost;
    internal int cas;
    internal int skore;
    internal DateTime datum;
}