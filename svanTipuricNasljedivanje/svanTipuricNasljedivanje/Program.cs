using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricNasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            u1.Ime = "Marko";
            u1.Prezime = "Marulic";
            u1.Razred = 3;
            Nastavnik n1 = new Nastavnik();
            n1.Ime = "MrKee";
            n1.Prezime = "ITMaster";
            n1.Predmet = "Programiranje do bola i zazad";

            Console.WriteLine(u1.ToString()+"Razred: " + u1.Razred);
            Console.WriteLine(n1.ToString()+"Predmet: " + n1.Predmet);
            Console.ReadKey();
        }
    }
}
