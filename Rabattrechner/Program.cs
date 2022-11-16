using System;
using static System.Console;

namespace Rabattrechner
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Nutzereingabe 
            WriteLine("Bitte geben Sie den Preis in Euro ein:");
            string Eingabewert = ReadLine();

            // Umwandlung und Berechnung
            double Rechnungsbetrag = Convert.ToDouble(Eingabewert);
            double Rabatt; 

            if (Rechnungsbetrag > 1000 && Rechnungsbetrag < 2000)
            {
                Rabatt = Rechnungsbetrag * 0.03;
            }
            else if (Rechnungsbetrag > 2000) {
               Rabatt = Rechnungsbetrag * 0.05;
            }
            else
            {
                Rabatt = 0;
            }
            double Rechnungssumme = Rechnungsbetrag - Rabatt;

            // Ausgabe
            WriteLine("Preis: " + Rechnungsbetrag + "€");
            WriteLine("Rabatt: " + Rabatt + "€");
            WriteLine("========================================");
            WriteLine("Rechnungssumme: " + Rechnungssumme + "€");

        }
    }
}
