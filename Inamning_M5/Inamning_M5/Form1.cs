using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning_M5
{
    public partial class Form1 : Form
    {
        private string myOperator = ""; //Skapar och initierar operanden.
        private double oldValue = 0; //Används till att spara uträkningar.
        private bool startClear = true; //Används till att indikera om programmet precis har startat eller om Clear har skett och en nolla finns i displayen.
        public Form1()
        {
            InitializeComponent();
        }
        private void CheckAndClearStartZero() //Används vid inmatning av tal och tar bort en startnolla som finns efter uppstart och clear.
        {
            if (startClear == true)
            {
                display.Text = ""; //Tar bort startnollan.
                startClear = false; //Indikerar att inmatning av ett tal har påbörjats.
            }
        }

        //Nedanstående button click metoder lägger in siffror i displayfönstret. De är händelse (event) drivna. Komma finns om man vill skriva in ett decimaltal.
        //Nummer-metoderna tar även bort nollan i början som finns efter uppstart och clear.
        private void nr0_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "0";
        }

        private void nr1_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "1";
        }

        private void nr2_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "2";
        }

        private void nr3_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "3";
        }

        private void nr4_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "4";
        }

        private void nr5_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "5";
        }

        private void nr6_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "6";
        }

        private void nr7_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "7";
        }

        private void nr8_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "8";
        }

        private void nr9_Click(object sender, EventArgs e)
        {
            CheckAndClearStartZero();
            display.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            display.Text += ",";
            startClear = false; //Indikerar att inmatning av ett tal har påbörjats. (Vill ha nollan kvar i början, så inget "CheckAndClearStartZero")
        }


        private void CalculateOrILoadNumber() //"Huvud" metod. Sparar siffer-inmatningen i oldValue om ingen operand är angiven. Annars så utför den beräkningarna och sparar undan resultatet, så att man kan fortsätta. Skriver även ut resultatet på displayerna.
        {
            if (!double.TryParse(display.Text, out double newValue))  //Kontrollerar att ett decimaltal finns i displayen. Det läses isålfall in i newValue.
            {
                newValue = double.NaN; //Om det ej gått bra.
            }
            else
            {
                switch (myOperator) //Denna switch utför beräkningarna:
                {
                    case "+":
                        newValue = oldValue + newValue;
                        break;
                    case "-":
                        newValue = oldValue - newValue;
                        break;
                    case "*":
                        newValue = oldValue * newValue;
                        break;
                    case "/":
                        newValue = oldValue / newValue;
                        break;
                    case "":
                        break;
                }
            }
            oldValue = newValue; //Spara undan newValue.
            display.Text = newValue.ToString(); //Skriver ut resultatet på displayen.
            displaySubResult.Text = newValue.ToString(); //Skriver ut på lilla displayen.
        }


        //Operandernas metoder. De är också händelsedrivna - på click.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CalculateOrILoadNumber(); //Det går att trycka på valfri operand för beräkníng, CalculateOrLoadNumber körs. CalculateOrLoadNumber skriver ut, antingen det inmatade talet eller det beräknade. Utskriften på displayen skrivs över direkt - se nedan i denna metod. Utskriften på lilla displayen blir kvar.
            myOperator = "+"; //Används i CalculateOrLoadNumber switchen.
            display.Text = ""; //Rensar display fönstret, så att nytt tal kan skrivas in.
        }

        //De övriga operanderna är implementerade på samma vis som btnAdd_Click, fast med andra operander:
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            CalculateOrILoadNumber();
            myOperator = "-";
            display.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CalculateOrILoadNumber();
            myOperator = "*";
            display.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            CalculateOrILoadNumber();
            myOperator = "/";
            display.Text = "";
        }


        //Lika med knappen:
        private void btnEquals_Click(object sender, EventArgs e)
        {
            CalculateOrILoadNumber(); //Efter beräkning går det går att fortsätta med nya beräkningar. Uträkningen står på displayen och läses in som newValue.
            myOperator = ""; //Nollställer operanden, så att det börjar det om när man trycker på en operand, newValue blir till oldValue.
            displaySubResult.Text = ""; //Lilla displayen töms, så att bara den "stora" syns.
        }

        //Clear:
        private void btnClear_Click(object sender, EventArgs e)
        {
            oldValue = 0;
            myOperator = "";
            display.Text = "0";
            displaySubResult.Text = "";
            startClear = true;
        }
    }
}
