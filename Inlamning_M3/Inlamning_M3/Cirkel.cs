using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inlamning_M3
{
    public class Cirkel : Figur //En klass, Cirkel, som ärver av Figur.
    {
        double radie; //En variabel som bara används här (field) och kan vara private (default).

        public Cirkel (double radie) //En konstruktor med en parameter som används vid skapandet av ett objekt.
        {
            this.radie = radie;
        }

        //Metoder som är definierade abstract i basklassen Figur och måste finnas.
        //override överskriver Get..() i basklassen.
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radie,2); //Area är en egenskap som är ärvd från basklassen.
            return Area;
        }
        public override double GetOmkrets()
        {
            Omkrets = 2 * Math.PI * radie; //Omkrets är en egenskap som är ärvd från basklassen.
            return Omkrets;
        }
        public override string GetFigureName()
        {
            return "cirkel";
        }

        //Används vid utskrift.
        public override string ToString()
        {
            return ("Du har angett en " + GetFigureName() + ". Arean är: " + GetArea() + " och omkretsen är: " + GetOmkrets() + ".");
        }
    }
}