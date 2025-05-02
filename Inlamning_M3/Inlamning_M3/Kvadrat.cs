using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inlamning_M3
{
    public class Kvadrat : Figur //En klass, Kvadrat, som ärver av Figur.
    {
        double sidLängd; //En variabel som bara används här (field) och kan vara private (default).

        public Kvadrat(double bredd) //En konstruktor med en parameter som används vid skapandet av ett objekt.
        { 
            this.sidLängd = bredd;
        }

        //Metoder som är definierade abstract i basklassen Figur och måste finnas.
        //override överskriver Get..() i basklassen.
        public override double GetArea()
        {   
            Area = sidLängd*sidLängd; //Area är en egenskap som är ärvd från basklassen.
            return Area;
        }
        public override double GetOmkrets()
        {
            Omkrets = sidLängd * 4; //Omkrets är en egenskap som är ärvd från basklassen.
            return Omkrets;
        }
        public override string GetFigureName()
        {
            return "kvadrat";
        }

        //Används vid utskrift.
        public override string ToString()
        {
           return ("Du har angett en " + GetFigureName() + ". Arean är: " + GetArea() + " och omkretsen är: " + GetOmkrets() + ".");
        }
    }
}