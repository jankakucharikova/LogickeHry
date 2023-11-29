using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class Uzivatel
    {
        public Uzivatel()
        {
            Id = Guid.NewGuid();
        }
        internal Guid Id { get; set; }
        internal string Jmeno;
        internal string HashHesla;
        internal string Pohlavi;
        internal string Vek;
        internal List<SudokuZadani> videl;
    }
}
