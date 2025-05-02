using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int räknaPar = 0;
            Kortlek minKortlek = new Kortlek(); //Skapar en kortlek, minKortlek, för mer info - se Kortlek.cs
            for (int i = 0; i < 1000; i++) //Loopar 1000 gånger.
            {
                if (minKortlek.DraPar()) //Metoden DraPar drar två kort och ser om de har har samma värde, den returnerar en boolean, för mer info - se Kortlek.cs.
                {
                    räknaPar++; 
                }
            }
            Console.WriteLine($"Du har fått {räknaPar} par");
        }
    }
}
