using System;

namespace Inlamning_M2
{
    public class Fordon //En class som innehåller diverse parametrar
    {
        private static int indexCount = 0; //Statisk räknare som skapar ett unikt id.

        private int id; //Deklaration av variabeln id.

        //Skapande av parametrarna. De ska vara skyddade enligt specifikation, alltså private set.
        public string Make { get; private set; }
        public string  Model { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }


        public int GetId() //Används för att läsa id under remove
        {
            return id;
        }


        public Fordon(string make, string model, string color, int year) //En construktor med 4 parametrar. Den kan anropas då man skapar ett fordon med samtliga parametrar.
        {
            this.Make = make;    //Sätter fordonets make till det som skickats in.
            this.Model = model;  //Sätter fordonets model till den som skickats in.
            this.Color = color;  //Sätter fordonets color till den som skickats in.
            this.Year = year;    //Sätter fordonets year till det som skickats in.
            this.id = indexCount;     //Sätter det unika id numret.
            indexCount++;  //Räknar upp id räknaren
        }

        public Fordon(string make, string model, int year) //En construktor med 3 parametrar. Den kan anropas då man skapar ett fordon utan color som input, alltså integer som tredje argument.
        {
            this.Make = make;    //Sätter fordonets make till det som skickats in.
            this.Model = model;  //Sätter fordonets model till den som skickats in.
            this.Year = year;    //Sätter fordonets yaer till det som skickats in.
            this.id = indexCount;     //Sätter det unika id numret.
            indexCount++;  //Räknar upp id räknaren
        }

        public Fordon(string make, string model, string color) //En construktor med 3 parametrar. Den kan anropas då man skapar ett fordon utan year som input, alltså string som tredje argument.
        {
            this.Make = make;     //Sätter fordonets make till det som skickats in.
            this.Model = model;   //Sätter model till den som skickats in.
            this.Color = color;   //Sätter fordonets color till den som skickats in.
            this.id = indexCount;      //Sätter det unika id numret.
            indexCount++;  //Räknar upp id räknaren
        }

        public override string ToString() 
            //ToString returnerar en string somt representerar objektet (Google).
            //Alltså ändrar detta Console.WriteLine(fordon) utskriften från "Inlamning_M2.Fordon" till utskriften av angiven string i return(stríng).
            //"Raden" behövdes dock förvandlas helt till string med string.Format. Vanlig ("bla" + variabel) samt $-varianten fungerar direkt.
        {
            string nyFordonString = string.Format("{0,-4}\t {1,-10}\t {2,-10}\t {3,-10}\t {4,-10}\t", id, Make, Model, Color, Year);
            return (nyFordonString);
        }
    }
}