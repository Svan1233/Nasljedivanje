using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricNasljedivanje
{
    class Osoba
    {
        string ime;
        string prezime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            string ispis = "\nIme: " + this.Ime + "\nPrezime: " + this.Prezime;
            return ispis;
        }
    }
}
