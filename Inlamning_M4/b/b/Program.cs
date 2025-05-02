using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kortlek minKortlek = new Kortlek(); //Skapar en kortlek, minKortlek, för mer info - se Kortlek.cs.
            while (minKortlek.kortleken.Count > 0) //Kortleken minskas när man drar ett kort, se Kortlek.cs. Whilen sker så länge det finns kort kvar.
            {
                Kort dragetKort = minKortlek.DraKort(); //Drar ett kort, se Kortlek.cs.
                Console.WriteLine("Draget kort: " + dragetKort);
            }
        }
    }
}
