using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Inlamning_M3
{
    public abstract class Figur //Basklassen
    {
        //Eegenskaper (properties) som kan användas i subklasser.
        protected double Area { get; set; }
        protected double Omkrets { get; set; }

        //Abstakta medlemsfunktioner. Dessa måste implementeras i subklasserna (pga abstract).
        public abstract double GetArea();
        public abstract double GetOmkrets();
        public abstract string GetFigureName();
    }
}