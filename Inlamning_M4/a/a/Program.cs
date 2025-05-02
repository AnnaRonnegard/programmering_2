using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> talLista = new List<double>(); //Skapar en lista som kommer att innehålla de inmatade talen. Jag tillåter decimaltal.
            while(true)
            {
                Console.WriteLine("Ange ett tal alternativt 0 för att avsluta:");
                if(!double.TryParse(Console.ReadLine(), out double tal)) {
                    Console.WriteLine("Du har inte angivit ett tal!\n");
                }
                else //Sker om inmatningen är ett tal.
                {
                    if (tal == 0)
                    {
                        break;//Bryter loopen om inmatningen = 0.
                    }
                    talLista.Add(tal); //Adderar det inmatade talet.
                    Console.WriteLine($"Medelvärdet av de inmatade talen är: {talLista.Average()}\n"); //Skriver ut medelvärdet.
                }
            }
        }
    }
}
