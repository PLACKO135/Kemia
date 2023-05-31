using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Kemia
    {

        string ev;
        string nev;
        string vegyjel;
        int rendszam;
        string felfedezo;

        public Kemia(string ev, string nev, string vegyjel, int rendszam, string felfedezo)
        {
            this.ev = ev;
            this.nev = nev;
            this.vegyjel = vegyjel;
            this.rendszam = rendszam;
            this.felfedezo = felfedezo;
        }

        public string Ev { get => ev; }
        public string Nev { get => nev;  }
        public string Vegyjel { get => vegyjel;  }
        public int Rendszam { get => rendszam;  }
        public string Felfedezo { get => felfedezo;  }
    }
}
