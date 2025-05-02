using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning_M3
{
    internal class Program
    {
        static void FelInmatning() //Anropas vid felaktig inmatning.
        {
            Console.WriteLine("\nDu angav inget tal!\nDecimaltal accepteras.\n\nTryck på valfri knapp för att börja om.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {

            while (true) //En evig loop. Programmet avbryts med return i switchen nedan.
            {
                Console.WriteLine("\n\t\tVälkommen " +
                    "\n\nNavigera dig genom menyn.\nVälj något av följande alternativ (0, 1, 2, 3, 4):"
                    + "\n0. Avsluta."
                    + "\n1. Beräkning av cirkel."
                    + "\n2. Beräkning av kvadrat."
                    + "\n3. Beräkning av rektangel."
                    + "\n4. Beräkning av triangel."
                    + "\n");

                char input; //Skapar en char som heter input och som används i switchen nedan.
                try     //Provar att läsa in första tecknet från consolen till input.
                {
                    Console.Write("Ditt val: ");
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException) //Om inputen är tom.
                {
                    input = ' '; //Ger input ett blanktecken. Felutskrift kommer i switchens default nedan.
                }

                switch (input)
                {
                    case '0':
                        return; //Avbryter hela proogrammet (Main).
                    case '1':
                        Console.WriteLine("Ange radien:");
                        bool testRadie = double.TryParse(Console.ReadLine(), out double radie);
                        if (!testRadie) //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Cirkel cirkel = new Cirkel(radie);  //Skapande av objektet cirkel.
                        Console.WriteLine(cirkel); //Utskrift av Cirkel klassens override ToString().
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '2':
                        Console.WriteLine("Ange sidlängden:");
                        bool testSidLängdKvadrat = double.TryParse(Console.ReadLine(), out double sidLängdKvadrat);
                        if (!testSidLängdKvadrat)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Kvadrat kvadrat = new Kvadrat(sidLängdKvadrat);  //Skapande av objektet kvadrat.
                        Console.WriteLine(kvadrat); //Utskrift av Kvadrat klassens override ToString().
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("Ange längden på sida 1:");
                        bool testSidLängd1Rektangel = double.TryParse(Console.ReadLine(), out double sidLängd1Rektangel);
                        if (!testSidLängd1Rektangel)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Console.WriteLine("Ange längden på sida 2:");
                        bool testSidLängd2Rektangel = double.TryParse(Console.ReadLine(), out double sidLängd2Rektangel);
                        if (!testSidLängd2Rektangel)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Rektangel rektangel = new Rektangel(sidLängd1Rektangel, sidLängd2Rektangel);  //Skapande av objektet rektangel.
                        Console.WriteLine(rektangel); //Utskrift av Rektangel klassens override ToString().
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '4':
                        Console.WriteLine("Ange längden på sida 1:");
                        bool testSidLängd1Trangel = double.TryParse(Console.ReadLine(), out double sidLängd1Triangel);
                        if (!testSidLängd1Trangel)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Console.WriteLine("Ange längden på sida 2:");
                        bool testSidLängd2Trangel = double.TryParse(Console.ReadLine(), out double sidLängd2Triangel);
                        if (!testSidLängd2Trangel)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Console.WriteLine("Ange längden på sida 3:");
                        bool testSidLängd3Trangel = double.TryParse(Console.ReadLine(), out double sidLängd3Triangel);
                        if (!testSidLängd3Trangel)  //Sker om man matat in annan än en siffra.
                        {
                            FelInmatning();
                            break;
                        }
                        Triangel triangel = new Triangel(sidLängd1Triangel, sidLängd2Triangel, sidLängd3Triangel);  //Skapande av objektet triangel.
                        Console.WriteLine(triangel); //Utskrift av Triangel klassens override ToString().
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: // Sker om input != 0,1,2, 3 eller 4.
                        Console.Clear();
                        Console.WriteLine("\nDu valde inget av alternativen!\nTryck på valfri knapp för att fortsätta.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
