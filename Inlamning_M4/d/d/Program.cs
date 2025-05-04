using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Skriv ett program som räknar ut förekomsten av ord i en text, histogram. Indatat är en text på minst femtio ord som du lägger i en sträng variabel. Var noga med att skala bort punkter, kommatecken, frågetecken? och utropstecken! samt lös att Det ska vara samma som det. Det här är mer än femtio ord.";
            Console.WriteLine("Indata är:\n" + input + '\n');
            string[] ord = input.Split(new char[] {' ', '.', ',', '?', '!'}, StringSplitOptions.RemoveEmptyEntries); //Läser in orden i en array.

            Dictionary<string, int> räknaOrd = new Dictionary<string, int>(); //Skapar en Dictionary, räknaOrd, som används sedan. Den skapas med nyckeln, Key, som en sträng och värdet, Value, som en integer.
            foreach (string ordet in ord)
            {
                string ordLower = ordet.ToLower(); //Ser till att alla orden sparas med små bokstäver, så att jämförelsen inte är case-sensitiv.
                if (räknaOrd.ContainsKey(ordLower)) //Kollar om ordet (som är Key) finns i räknaOrd
                {
                    räknaOrd[ordLower]++; //Räknar isåfall upp värdet (Value)
                }
                else //Om ordet inte finns i räknaOrd
                {
                    räknaOrd.Add(ordLower, 1); //Lägger till det i räknaOrd och sätter värdet till 1 (ordet finns nu en gång).
                }
            }

            List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>(); //Skapar en lista av typen "KeyValuePair<string, int>" som döps till sortedList. Detta för att man på en lista kan använda sort().

            foreach (KeyValuePair<string, int> nyckelPar in räknaOrd)
            {
                sortedList.Add(nyckelPar); //Lägger in räknaOrd's innehåll (KeyValuePair) i sortedList.
            }

            sortedList.Sort((x, y) => x.Value.CompareTo(y.Value)); //Sorterar sortedList på värdet (Value). Lägsta hamnar först.
            sortedList.Reverse(); //Ser till att högsta värdet kommer först. 
            
            foreach (KeyValuePair<string, int> nyckelPar in sortedList)
            {
                Console.WriteLine($"{nyckelPar.Key}: {nyckelPar.Value} gång"); //Skrivër ut den sorterade listan.
            }
        }
    }
}
