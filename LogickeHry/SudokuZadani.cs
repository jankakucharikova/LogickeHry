using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LogickeHry;

internal class SudokuZadani
{
    private struct Souradnice
    {
        public int x, y;
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj.GetType() != GetType()) return false;
            return x == ((Souradnice)obj).x && y == ((Souradnice)obj).y;
        }
    }
    private readonly Random _rnd = new();
    internal int[,] kompletni;
    internal int[,] zadani;
    internal string text;
    internal string obtiznost;

    internal void Load()
    {
        kompletni = new int[9, 9];
        zadani = new int[9, 9];
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                kompletni[i, j] = int.Parse(text[i * 9 + j].ToString());
                zadani[i, j] = int.Parse(text[i * 9 + j + 81].ToString());
            }
        }
    }
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
    internal Guid Id { get; init; } = Guid.NewGuid();

    internal void Vygeneruj(Obtiznost obtiznostHry)
    {
        obtiznost = obtiznostHry.ToString();
        kompletni = new int[9, 9];
        zadani = new int[9, 9];
        GenerateCompleteSudoku(0);
        GenerateUniqueSudoku(obtiznostHry);
    }

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
            list.Remove(sudoku[blockRow + i, blockCol + j]); // KOntrola čtverce

        return list;
    }

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

    private bool Rekurzivnizkouseni(int[,] rozdily, int z)
    {
        if (z == 81)
        {
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                    if (zadani[i, j] != kompletni[i, j])
                        rozdily[i, j]++;
            }
            return true;
        }


        var x = z % 9;
        var y = z / 9;

        if (zadani[x, y] != 0)
            return Rekurzivnizkouseni(rozdily, z + 1);

        var list = Kandidati(zadani, x, y);

        foreach (var num in list)
        {
            zadani[x, y] = num;
            Rekurzivnizkouseni(rozdily, z + 1);
        }

        zadani[x, y] = 0;
        return false;
    }
}