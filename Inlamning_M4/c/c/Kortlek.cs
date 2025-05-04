using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    public class Kortlek
    {
        private List<Kort> kortleken = new List<Kort>(); //Skapar en lista med kort kallad kortleken.
        private Random slumpGenerator = new Random(); //Initierar en slumpgenerator.

        public Kortlek() //En konstruktor utan parametrar, skapar en kortlek.
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

        public bool DraPar() //En metod som drar två kort och checkar om de är ett par. En booölean returneras.
        {
            int slumptalEtt = slumpGenerator.Next(0, kortleken.Count()); //Slumpar fram ett slumptal mellan 0 och upp till så många kort som kortleken innehåller.
            Kort dragetKortEtt = kortleken[slumptalEtt]; //Skapar ett slumpmässing kort ur kortleken.

            kortleken.Remove(dragetKortEtt); // Tar bort det dragna kortet, så att det inte kan dras igen.

            int slumptalTvå = slumpGenerator.Next(0, kortleken.Count()); //Slumpar fram ett slumptal mellan 0 och upp till så många kort som kortleken innehåller, vilket nu är ett mindre.
            Kort dragetKortTvå = kortleken[slumptalTvå];

            kortleken.Add(dragetKortEtt); //Lägger tillbaka kort ett, så att kortleken blir som ny igen.

            bool Par = false;
            if (dragetKortEtt.GetVärde() == dragetKortTvå.GetVärde()) //Kollar om de två korten har samma värde.
                {
                    Par = true;
                }
            return Par;
        }
    }
}
