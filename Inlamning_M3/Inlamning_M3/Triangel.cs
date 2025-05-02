using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Inlamning_M3
{
    public class Triangel : Figur //En klass, Triangel, som ärver av Figur.
    {
        //Variabler som bara används här (fields) och kan vara private (default).
        double sidLängd1;
        double sidLängd2;
        double sidLängd3;

        public Triangel(double sidLängd1, double sidLängd2, double sidLängd3) //En konstruktor med tre parametrar som används vid skapandet av ett objekt.
        {
            this.sidLängd1 = sidLängd1;
            this.sidLängd2 = sidLängd2;
            this.sidLängd3 = sidLängd3;
        }

        //Metoder som är definierade abstract i basklassen Figur och måste finnas.
        //override överskriver Get..() i basklassen.
        public override double GetArea() //Uträkningen kommer från Herons formel.
        {   
            double s = GetOmkrets()/2; //En hjälpvariabel - uträkningen blir mer lättläslig.
            Area = Math.Sqrt(s*(s-sidLängd1)*(s-sidLängd2)*(s-sidLängd3)); //Area är en egenskap som är ärvd från basklassen.
            return Area;
        }
        public override double GetOmkrets()
        {
            Omkrets = sidLängd1 + sidLängd2 + sidLängd3; //Omkrets är en egenskap som är ärvd från basklassen.
            return Omkrets;
        }
        public override string GetFigureName()
        {
            return "triangel";
        }

        //Används vid utskrift.
        public override string ToString()
        {
            return ("Du har angett en " + GetFigureName() + ". Arean är: " + GetArea() + " och omkretsen är: " + GetOmkrets() + ".");
        }
    }
}