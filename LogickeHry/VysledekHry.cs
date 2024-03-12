using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class VysledekHry
    {

        internal Guid Id { get; set; } = Guid.NewGuid();
        internal Uzivatel uzivatel;
        internal string hra;
        internal string obtiznost;
        internal int cas;
    }
}
