using System;

namespace Inlamning_M2
{
    public class Fordon //En class som inneh�ller diverse parametrar
    {
        private static int indexCount = 0; //Statisk r�knare som skapar ett unikt id.

        private int id; //Deklaration av variabeln id.

        //Skapande av parametrarna. De ska vara skyddade enligt specifikation, allts� private set.
        public string Make { get; private set; }
        public string  Model { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }


        public int GetId() //Anv�nds f�r att l�sa id under remove
        {
            return id;
        }


        public Fordon(string make, string model, string color, int year) //En construktor med 4 parametrar. Den kan anropas d� man skapar ett fordon med samtliga parametrar.
        {
            this.Make = make;    //S�tter fordonets make till det som skickats in.
            this.Model = model;  //S�tter fordonets model till den som skickats in.
            this.Color = color;  //S�tter fordonets color till den som skickats in.
            this.Year = year;    //S�tter fordonets year till det som skickats in.
            this.id = indexCount;     //S�tter det unika id numret.
            indexCount++;  //R�knar upp id r�knaren
        }

        public Fordon(string make, string model, int year) //En construktor med 3 parametrar. Den kan anropas d� man skapar ett fordon utan color som input, allts� integer som tredje argument.
        {
            this.Make = make;    //S�tter fordonets make till det som skickats in.
            this.Model = model;  //S�tter fordonets model till den som skickats in.
            this.Year = year;    //S�tter fordonets yaer till det som skickats in.
            this.id = indexCount;     //S�tter det unika id numret.
            indexCount++;  //R�knar upp id r�knaren
        }

        public Fordon(string make, string model, string color) //En construktor med 3 parametrar. Den kan anropas d� man skapar ett fordon utan year som input, allts� string som tredje argument.
        {
            this.Make = make;     //S�tter fordonets make till det som skickats in.
            this.Model = model;   //S�tter model till den som skickats in.
            this.Color = color;   //S�tter fordonets color till den som skickats in.
            this.id = indexCount;      //S�tter det unika id numret.
            indexCount++;  //R�knar upp id r�knaren
        }

        public override string ToString() 
            //ToString returnerar en string somt representerar objektet (Google).
            //Allts� �ndrar detta Console.WriteLine(fordon) utskriften fr�n "Inlamning_M2.Fordon" till utskriften av angiven string i return(str�ng).
            //"Raden" beh�vdes dock f�rvandlas helt till string med string.Format. Vanlig ("bla" + variabel) samt $-varianten fungerar direkt.
        {
            string nyFordonString = string.Format("{0,-4}\t {1,-10}\t {2,-10}\t {3,-10}\t {4,-10}\t", id, Make, Model, Color, Year);
            return (nyFordonString);
        }
    }
}