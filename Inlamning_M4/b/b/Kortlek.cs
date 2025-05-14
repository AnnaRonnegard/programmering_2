using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    public class Kortlek
    {
        private List<Kort> kortleken = new List<Kort>(); //Skapar en lista med kort kallad kortleken.

        private Random slumpGenerator = new Random(); //Initierar en slumpgenerator.

        public Kortlek() //En konstruktor utan parametar, skapar en kortlek.
        {
            for (int i = 1; i <= 13; i++) //Loopar igenom de 13 värdena.
            {
                for (int j = 0; j <= 3; j++) //Loopar igenom de 4 färgerna.
                {
                    int färgKod = j;
                    int värdeKod = i;
                    Kort.Färg färgEnum = (Kort.Färg)färgKod; //Översätter talet till typen Kort.Färg - se enum i Kort.cs.
                    Kort.Värde värdeEnum = (Kort.Värde)värdeKod; //Översätter talet till typen Kort.Värde - se enum i Kort.cs.
                    Kort nyttKort = new Kort(färgEnum, värdeEnum); //Skapar kortet.
                    kortleken.Add(nyttKort); //Lägger in det nya kortet i kortleken.
                }
            }
        }

        public int GetKortlekCount() //Gör kortleken.count läsbart från main.
        {
            return kortleken.Count;
        }

        public Kort DraKort() //En metod som drar ett kort ur kortleken.
        {
            int slumptal = slumpGenerator.Next(0, kortleken.Count()); //Slumpar fram ett slumptal mellan 0 och upp till så många kort som kortleken innehåller.
            Kort returKort = kortleken[slumptal]; //Skapar ett slumpmässing kort ur kortleken.
            kortleken.RemoveAt(slumptal); //Tar bort det dragna kortet ur kotrléken.
            return returKort;
        }
    }
}
