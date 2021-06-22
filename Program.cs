using System;

namespace AE_Geometrieobjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // In der Main() werden zum Testen einzelner
            // Objekte der Klassen mit dem new-Operator
            // erzeugt (instanziiert) und die Methoden
            // per Punktnotation aufgerufen.
            // Objekterzeugung:
            Punkt ursprung  = new Punkt(0, 0);
            Punkt punkt     = new Punkt(0, 1);
            Kreis kreis     = new Kreis(1, ursprung);
            Vektor vektor   = new Vektor(ursprung, punkt);

            // Ausgabe der Ergebnisse der einzelnen 
            // Methodenaufrufe mit 14 Nachkommastellen
            Console.WriteLine("Der Kreisinhalt beträgt: {0}", kreis.InhaltBerechnen());
            Console.WriteLine("Der Kreisumfang beträgt: {0}", kreis.UmfangBerechnen());
            Console.WriteLine("Die Vektorlänge beträgt: {0}", vektor.LängeBerechnen());

            //Programm anhalten
            Console.Write("\n\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    } // class
} // namespace
