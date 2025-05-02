using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inlamning_M3
{
    public class Rektangel : Figur //En klass, Rektangel, som ärver av Figur.
    {
        //Variabler som bara används här (fields) och kan vara private (default).
        double sidLängd1;
        double sidLängd2;

        public Rektangel(double sidLängd1, double sidLängd2) //En konstruktor med två parametrar som används vid skapandet av ett objekt.
        {
            this.sidLängd1 =  sidLängd1;
            this.sidLängd2 = sidLängd2;
        }

        //Metoder som är definierade abstract i basklassen Figur och måste finnas.
        //override överskriver Get..() i basklassen.
        public override double GetArea()
        {
            Area = sidLängd1*sidLängd2; //Area är en egenskap som är ärvd från basklassen.
            return Area;
        }
        public override double GetOmkrets()
        {
            Omkrets = sidLängd1*2 + sidLängd2*2; //Omkrets är en egenskap som är ärvd från basklassen.
            return Omkrets;
        }
        public override string GetFigureName()
        {
            return "rektangel";
        }

        //Används vid utskrift.
        public override string ToString()
        {
            return ("Du har angett en " + GetFigureName() + ". Arean är: " + GetArea() + " och omkretsen är: " + GetOmkrets() + ".");
        }
    }
}