using Google.Protobuf.WellKnownTypes;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LogickeHry;

internal class SudokuZadani
{
    // Struktura pro reprezentaci souřadnic
    private struct Souradnice
    {
        public int x, y;
        // Přepsání metody Equals pro porovnání souřadnic
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            // Porovnání typu objektu
            if (obj.GetType() != GetType()) return false;
            // Porovnání hodnot souřadnic
            return x == ((Souradnice)obj).x && y == ((Souradnice)obj).y;
        }
    }
    // Instance generátoru náhodných čísel
    private readonly Random _rnd = new();
    // Pole pro uložení kompletního sudoku a zadání sudoku
    internal int[,] kompletni;
    internal int[,] zadani;
    // Textová reprezentace sudoku
    internal string text;
    internal string obtiznost;

    // Metoda pro načtení sudoku ze stringu
    internal void Load()
    {
        kompletni = new int[9, 9];
        zadani = new int[9, 9];
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                // Naplnění kompletního a zadání sudoku
                kompletni[i, j] = int.Parse(text[i * 9 + j].ToString());
                zadani[i, j] = int.Parse(text[i * 9 + j + 81].ToString());
            }
        }
    }

    // Metoda pro uložení sudoku do stringu
    internal void Save()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                sb.Append(kompletni[i, j]);

            }
        }
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                sb.Append(zadani[i, j]);

            }
        }
        text = sb.ToString();
    }
    // Id sudoku
    internal Guid Id { get; init; } = Guid.NewGuid();

    // Metoda pro vygenerování sudoku
    internal void Vygeneruj(Obtiznost obtiznostHry)
    {
        // Nastavení obtížnosti
        obtiznost = obtiznostHry.ToString();
        kompletni = new int[9, 9];
        zadani = new int[9, 9];
        GenerateCompleteSudoku(0);
        GenerateUniqueSudoku(obtiznostHry);
    }

    // Metoda pro generování kompletního sudoku
    private bool GenerateCompleteSudoku(int z)
    {
        if (z == 81)
            return true;

        var x = z % 9;
        var y = z / 9;
        var list = Kandidati(kompletni, x, y);

        while (list.Any())
        {
            var r = _rnd.Next() % list.Count;
            kompletni[x, y] = list[r];
            list.RemoveAt(r);

            if (GenerateCompleteSudoku(z + 1))
                return true;

            kompletni[x, y] = 0;
        }

        return false;
    }

    // Metoda pro nalezení kandidátů pro danou pozici v sudoku
    private List<int> Kandidati(int[,] sudoku, int x, int y)
    {
        var list = new List<int>(Enumerable.Range(1, 9));

        for (var i = 0; i < 9; i++)
        {
            list.Remove(sudoku[i, y]); // Kontrola řádku
            list.Remove(sudoku[x, i]); // Kontrola sloupce
        }

        var blockRow = x / 3 * 3;
        var blockCol = y / 3 * 3;

        for (var i = 0; i < 3; i++)
        for (var j = 0; j < 3; j++)
            list.Remove(sudoku[blockRow + i, blockCol + j]); // Kontrola čtverce 3x3

        return list;
    }
    // Metoda pro generování unikátního sudoku podle zvolené obtížnosti
    private void GenerateUniqueSudoku(Obtiznost obtiznostHry)
    {
        var pridani = obtiznostHry switch
        {
            Obtiznost.Lehke => 45,
            Obtiznost.Stredni => 35,
            Obtiznost.Tezke => 25,
            _ => 0
        };
        for (var i = 0; i < pridani; i++)
        {
            PridejRandomCislo();
        }
        var maxrozdil = 0;
        var kdeRozdil = new List<Souradnice>();
        while (true)
        {
            var rozdily = Rozdilyreseni();
            for (var i = 0; i < 9; i++)
            for (var j = 0; j < 9; j++)
            {
                if (rozdily[i, j] < maxrozdil) continue;
                if (rozdily[i, j] > maxrozdil)
                {
                    maxrozdil = rozdily[i, j];
                    kdeRozdil.Clear();
                }

                kdeRozdil.Add(new Souradnice { x = i, y = j });
            }
            if (maxrozdil == 0)
                break;
            var s = kdeRozdil[_rnd.Next(0, kdeRozdil.Count)];
            zadani[s.x, s.y] = kompletni[s.x, s.y];
            pridani++;
            maxrozdil = 0;
            kdeRozdil.Clear();
        }

    }

    // Metoda pro přidání náhodného čísla do sudoku
    private void PridejRandomCislo()
    {
        var x = _rnd.Next(0, 9);
        var y = _rnd.Next(0, 9);
        while (zadani[x, y] != 0)
        {
            x = _rnd.Next(0, 9);
            y = _rnd.Next(0, 9);
        }
        zadani[x, y] = kompletni[x, y];
    }
    private int[,] Rozdilyreseni()
    {
        var rozdily = new int[9, 9];
        Rekurzivnizkouseni(rozdily, 0);
        return rozdily;
    }

    // Metoda pro rekurzivní zkoušení možných čísel na danou pozici v sudoku
    private bool Rekurzivnizkouseni(int[,] rozdily, int z)
    {
        // Pokud je z == 81, znamená to, že byly zkoušeny všechny pozice v sudoku
        if (z == 81)
        {
            // Porovnání zadání se kompletním řešením
            for (var i = 0; i < 9; i++)
            {
                // Pokud se čísla v zadání a kompletním řešení liší, inkrementujeme rozdíl v rozdílech
                for (var j = 0; j < 9; j++)
                    if (zadani[i, j] != kompletni[i, j])
                        rozdily[i, j]++;
            }
            return true;// Návrat true, znamená, že všechny pozice byly zkoušeny
        }

        // Výpočet x a y souřadnic z indexu z
        var x = z % 9;
        var y = z / 9;

        // Pokud je na dané pozici v zadání již číslo, přeskočíme a pokračujeme na další pozici
        if (zadani[x, y] != 0)
            return Rekurzivnizkouseni(rozdily, z + 1);
        // Seznam možných kandidátů pro danou pozici v zadání
        var list = Kandidati(zadani, x, y);
        // Procházíme všechny možné kandidáty pro danou pozici
        foreach (var num in list)
        {
            zadani[x, y] = num;// Nastavíme číslo na danou pozici
            // Rekurzivně voláme metodu pro zkoušení další pozice
            Rekurzivnizkouseni(rozdily, z + 1);
        }

        zadani[x, y] = 0; // Pokud žádný kandidát nevyhovuje, nastavíme zpět na 0 a backtracking
        return false; // Návrat false, protože nebyla nalezena platná konfigurace
    }
}