using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class SudokuZadani
    {
        struct souradnice
        {
            public int x, y;
            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                if (obj.GetType() != this.GetType()) return false;
                return x == ((souradnice)obj).x && y == ((souradnice)obj).y;
            }
        }
        private Random rnd = new Random();
        internal int[,] kompletni;
        internal int[,] zadani;
        internal string text;
        internal String obtiznost;

        internal void Load()
        {
            kompletni = new int[9, 9];
            zadani = new int[9, 9];
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    kompletni[i, j] = int.Parse(text[i*9+j].ToString());
                    zadani[i,j] = int.Parse(text[i*9+j+81].ToString());
                }
            }
        }
        internal void save()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(kompletni[i, j]);

                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(zadani[i, j]);

                }
            }
            text= sb.ToString();
        }
        internal Guid Id { get; set; } = Guid.NewGuid();
        internal SudokuZadani()
        {
            
        }
        internal void vygeneruj(Obtiznost obtiznost)
        {
            this.obtiznost= obtiznost.ToString();
            kompletni = new int[9, 9];
            zadani = new int[9, 9];
            GenerateCompleteSudoku(0);
            GenerateUniqueSudoku(obtiznost);
        }

        bool GenerateCompleteSudoku(int z)
        {
            if (z == 81)
                return true;

            int x = z % 9;
            int y = z / 9;
            List<int> list = kandidati(kompletni, x, y);

            while (list.Count() > 0)
            {
                int r = rnd.Next() % list.Count();
                kompletni[x, y] = list[r];
                list.RemoveAt(r);

                if (GenerateCompleteSudoku(z + 1))
                    return true;

                kompletni[x, y] = 0;
            }

            return false;
        }

        List<int> kandidati(int[,] sudoku, int x, int y)
        {
            List<int> list = new List<int>(Enumerable.Range(1, 9));

            for (int i = 0; i < 9; i++)
            {
                list.Remove(sudoku[i, y]); // Kontrola řádku
                list.Remove(sudoku[x, i]); // Kontrola sloupce
            }

            int blockRow = x / 3 * 3;
            int blockCol = y / 3 * 3;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    list.Remove(sudoku[blockRow + i, blockCol + j]); // KOntrola čtverce

            return list;
        }

        void GenerateUniqueSudoku(Obtiznost obtiznost)
        {
            int pridani = 0;
            switch (obtiznost)
            {
                case Obtiznost.Lehke:
                    pridani = 45;
                    break;
                case Obtiznost.Stredni:
                    pridani = 35;
                    break;
                case Obtiznost.Tezke:
                    pridani = 25;
                    break;
            }
            for (int i = 0; i < pridani; i++)
            {
                pridejRandomCislo();
            }
            int maxrozdil = 0;
            List<souradnice> kde_rozdil = new List<souradnice>();
            while (1 == 1)
            {
                int[,] rozdily = rozdilyreseni();
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (rozdily[i, j] >= maxrozdil)
                        {
                            if (rozdily[i, j] > maxrozdil)
                            {
                                maxrozdil = rozdily[i, j];
                                kde_rozdil.Clear();
                            }

                            kde_rozdil.Add(new souradnice() { x = i, y = j });
                        }
                    }
                if (maxrozdil == 0)
                    break;
                souradnice s = kde_rozdil[rnd.Next(0, kde_rozdil.Count())];
                zadani[s.x, s.y] = kompletni[s.x, s.y];
                pridani++;
                maxrozdil = 0;
                kde_rozdil.Clear();
            }

        }
        public void pridejRandomCislo()
        {
            int x = rnd.Next(0, 9);
            int y = rnd.Next(0, 9);
            while (zadani[x, y] != 0)
            {
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
            }
            zadani[x, y] = kompletni[x, y];
        }
        private int[,] rozdilyreseni()
        {
            int[,] rozdily = new int[9, 9];
            rekurzivnizkouseni(rozdily, 0);
            return rozdily;
        }

        private bool rekurzivnizkouseni(int[,] rozdily, int z)
        {
            if (z == 81)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                        if (zadani[i, j] != kompletni[i, j])
                            rozdily[i, j]++;
                }
                return true;
            }


            int x = z % 9;
            int y = z / 9;

            if (zadani[x, y] != 0)
                return rekurzivnizkouseni(rozdily, z + 1);

            List<int> list = kandidati(zadani, x, y);

            foreach (int num in list)
            {
                zadani[x, y] = num;
                rekurzivnizkouseni(rozdily, z + 1);
            }

            zadani[x, y] = 0;
            return false;
        }
    }
}
