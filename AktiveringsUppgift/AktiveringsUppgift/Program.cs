using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktiveringsUppgift
{
    internal class Program
    {
        #region 1. ListaFordon
        static void ListaBilar(string[] inBilar) //En metod som listar bilarna.
        {
            Console.WriteLine();
            foreach (string bil in inBilar) //Söker igenom arrayen inBilar* occh sparar dom i bil.
                Console.WriteLine(bil);     //Skriver ut bil.
            Console.ReadLine();
            return;   //Går tillbaka från metoden.
        }
        #endregion

        #region 2. ErsattaBil
        static void ErsattaBil(string[] inBilar)  //En metod som byter ut en bil.
        {
            Console.WriteLine("Vilket nummer vill du ändra? ");
            for (int i = 0; i < inBilar.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}. {inBilar[i]}"); //Skriver ut arrayen med bilar med 1-5 innan
            }
            int nummer = Int32.Parse(Console.ReadLine());
            Console.Write("Nämn ett bilmärke: ");
            inBilar[nummer - 1] = Console.ReadLine(); //Läser in ny bil på index = nummer-1, dvs 0-4.
            Console.ReadLine();
            return; //Går tillbaka från metoden.
        }
        #endregion


        static void Main(string[] args)
        {

            string[] bilar = { "Volvo", "Audi", "Ferrari", "Opel", "BMW" };

            while (true) //En evig loop. Programmet avbryts med return i switchen nedan.
            {
                Console.Clear(); //Rensar consolen.
                Console.WriteLine("\n\t\tVälkommen " +
                    "\n\nNavigera dig genom menyn genom att trycka nummer \n(1, 2, 0) för ditt val"
                    + "\n\n0. Avsluta dialogen"
                    + "\n1. Lista fordonen"
                    + "\n2. Ersätta ett fordon i listan");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try     //Provar att läsa in första tecknet från consolen till input.
                {
                    Console.Write("Ditt val: ");
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.WriteLine("Please enter some input or 0 to exit the application! Hit any key to continue.");
                    Console.ReadLine();
                    Console.Clear();  //Rensar consolen.
                }

                if (input > '2') //Checkar om input är större än ascii'n för 2
                {
                    Console.WriteLine("You have to choose an option! Hit any key to continue.");
                    Console.ReadLine();
                    Console.Clear();  //Rensar consolen.
                }
                else  //Sker om input är mindre eller lika med än ascii'n för 2
                {
                    switch (input)
                    {
                        case '0':
                            return; //Avbryter hela proogrammet (Main).
                        case '1':
                            ListaBilar(bilar); //Anropar metoden ListaBiler med arrayen bilar som argument.
                            break; //Går ur switckhen.
                        case '2':
                            ErsattaBil(bilar);  //Anropar metoden ErsattaBil med arrayen bilar som argument.
                            break;  //Går ur switckhen.
                        default:
                           break;  //Går ur switckhen. Sker om input != 0, 1 eller 2. (Samt uppfyller else ovan)
                    }
                }
            }
        }
    }
}
