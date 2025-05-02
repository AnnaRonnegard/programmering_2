using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    public class Kort //Här skapas ett kort.
    {
        private Färg färg; //Skapar en variabel, färg, Typen Färg är en enum - se nedan.
        private Värde värde; //Skapar en variabel värde, typen Värde är en enum - se nedan.

        public Kort(Färg färgIn, Värde värdeIn) // En konstruktor med två parametrar, färgIn och värdeIn, av typen Färg och Värde.
        {
            this.färg = färgIn;
            this.värde = värdeIn;
        }

        public Värde GetVärde() //Gör kortets värde läsbart.
        {
            return värde;
        }

        public Färg GetFärg() //Gör kortets färg läsbar.
        {
            return färg;
        }

        public enum Färg //Färgen motsvaras av siffror.
        {
            Klöver = 0,
            Ruter = 1,
            Spader = 2,
            Hjärter = 3
        }

        public enum Värde //Värdena motsvaras av siffror.
        {
            ess = 1,
            två = 2,
            tre = 3,
            fyra = 4,
            fem = 5,
            sex = 6,
            sju = 7,
            åtta = 8,
            nio = 9,
            tio = 10,
            knekt = 11,
            dam = 12,
            kung = 13
        }
        public override string ToString()
        {
            return $"{färg} {värde}";
        }
    }
}
