using System;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Inlamning_M2
{
    internal class Program
    {
        static void SkrivaLista(List<Fordon> fordons)  //En metod som loopar igenom listan av fordon och skriver ut fordonen med id och deras egenskaper (parametrar).
        {
            Console.WriteLine("{0,-4}\t {1,-10}\t {2,-10}\t {3,-10}\t {4,-10}\t", "Id", "Fordontyp", "Modell", "Färg", "År");
            Console.WriteLine();
            foreach (Fordon fordon in fordons)
            {
                Console.WriteLine(fordon); //I classen Fordon finns en override string ToString() som används av Console.WriteLine(), se Fordon.cs. Ville prova detta.
            }
            Console.WriteLine();
        }

        static void Main(string[] args) 
        {
            Fordon Mustang = new Fordon("Bil", "Mustang", "Blå", 2010);  //Skapar ett fordon
            Fordon Monark = new Fordon("Cykel", "Monark", "Röd", 2018);  //Skapar ett fordon
            Fordon Yamaha = new Fordon("Moped", "Yamaha", "Gul", 1976);  //Skapar ett fordon

            List<Fordon> FordonLista = new List<Fordon>(){Mustang, Monark, Yamaha}; //Skapar en lista "FordonLista" - med de fördefínierade fordonen (enligt rekomendation).

            //Deklaration av variabler som används vid inläsning och skapande av fordon.
            string make;
            string model;
            string color;
            int year;

            bool removeLyckas = false; //En variabel som indikerar att remove lyckats och aktuellt id finns i listan. Det finns en felutskrift annars.

            while (true) //En evig loop. Programmet avbryts med return i switchen nedan.
            {
                Console.WriteLine("\n\t\tVälkommen " +
                    "\n\nNavigera dig genom menyn genom att trycka nummer \n(+, -, L, 0) för ditt val"
                    + "\n\n0. Avsluta dialogen"
                    + "\n+. Lägga till ett fordon"
                    + "\n-. Ta bort ett fordon"
                    + "\nL. Lista fordonen");

                char input = ' '; //Skapar en char som heter input som används i switchen nedan.
                try     //Provar att läsa in första tecknet från consolen till input.
                {
                    Console.Write("Ditt val: ");
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException) //Om inputen är tom, så frågar vi efter giltigt input.
                {
                    Console.WriteLine("\nVar vänlig ange ett giltigt värde! Tryck på valfri knapp för att fortsätta.\n");
                    Console.ReadLine();
                    Console.Clear();
                }

                switch (input)
                {
                    case '0':
                        return; //Avbryter hela proogrammet (Main).
                    case '+':;  //Inputs värde för att lägga till ett fordon.
                        Console.WriteLine("Vilken typ av fordon vill du lägga till:");
                        make = Console.ReadLine();
                        Console.WriteLine("Vilken modell:");
                        model = Console.ReadLine();
                        Console.WriteLine("Vilken färg har det:");
                        color = Console.ReadLine();
                        Console.WriteLine("Vilket är tillverkningsåret:");
                        bool testYear = (Int32.TryParse(Console.ReadLine(), out year)); //Kontrollerar om inläsningen är en integer och läser in year.
                        if (testYear) //Sker om parsen gått bra.
                        {
                            Fordon nyttFordon = new Fordon(make, model, color, year); //Skapar ett Fordon med variabelnamnet nyttFordon. Parametrarna sätts till de inlästa värdena.
                            FordonLista.Add(nyttFordon); //Adderar fordonet till listan.
                            Console.WriteLine("\nDu har lyckats addera ett fordon!\n");
                            SkrivaLista(FordonLista);  //Anropar metoden SkrivaLista som finns ovan med FordonLista som argument, enligt specifikation.
                        }
                        else //Sker om inläsningen av year inte var en integer.
                        {
                            Console.WriteLine("\nDu har inte skrivit in en siffra på år!\nInget fordon har adderats!\n");
                        }             
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '-':
                        SkrivaLista(FordonLista);  //Anropar metoden SkrivaLista som finns ovan med FordonLista som argument. Det blir enklare att läsa önskat id på det fordon som ska tas bort.
                        Console.WriteLine("Ange id på det fordon du vill du ta bort:");
                        bool testParse = Int32.TryParse(Console.ReadLine(), out int removeId); //Testar om input är en integer och läser in i removeId.
                        if (testParse) //Sker om parsen till integer gått bra,
                        {
                            for (int i = 0; i < FordonLista.Count; i++) //Loopar igenom fordon listan.
                            {
                                if (FordonLista[i].GetId() == removeId) //Kontrollerar om id'n stämmer med removeId.
                                {
                                    FordonLista.RemoveAt(i); //Om det stämmer tas fordonet bort vid aktuellt index.
                                    Console.WriteLine("\nDu har lyckats radera ett fordon!\n");
                                    removeLyckas = true; //Sätter en boolean som används till att inte skriva ut felutskrift nedan.
                                    SkrivaLista(FordonLista);  //Anropar metoden SkrivaLista som finns ovan med FordonLista som argument, enligt specifikation.
                                    break;
                                }
                            }
                            if (!removeLyckas)
                            {
                                Console.WriteLine("\nDu har inte angett ett giltigt id.\nInget fordon har raderats!\n");
                            }
                            removeLyckas = false; //Återställer boolean till nästa gång, om den skulle vara satt.
                        }
                        else //Sker om parsen till integer inte gått bra.
                        {
                            Console.WriteLine("\nDu har inte angett en siffra.\nInget fordon har raderats!\n");
                        }
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 'L': //Inputs värde för att lista fordonen om man vill.
                        SkrivaLista(FordonLista); //Anropar metoden SkrivaLista som finns ovan med FordonLista som argument.
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: // Sker om input != 0, +, - eller L.
                        Console.Clear();
                        Console.WriteLine("\nDu har angett ett felaktigt input!\n");
                        Console.WriteLine("Var vänlig ange ett giltigt värde! Tryck på valfri knapp för att fortsätta.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}