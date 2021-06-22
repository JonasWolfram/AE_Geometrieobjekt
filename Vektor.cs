using System;

namespace AE_Geometrieobjekt
{
    public class Vektor
    {
        private Punkt startpunkt;
        private Punkt endpunkt;
        
        // Konstruktoren
        public Vektor()
        {

        }

        public Vektor(Punkt startpunkt, Punkt endpunkt)
        {
            this.startpunkt = startpunkt;
            this.endpunkt = endpunkt;
        }

        // Methoden
        public double LängeBerechnen()
        {
            // Direkte Berechnung mit in der Rückgabe
            return Math.Sqrt(
                Math.Pow(startpunkt.GetX() - endpunkt.GetX(), 2) +
                Math.Pow(startpunkt.GetY() - endpunkt.GetY(), 2));
                // Einzelberechnung
                // double längeX = startpunkt.GetX() - endpunkt.GetX();
                // double längeY = startpunkt.GetY() - endpunkt.GetY();
                // return Math.Sqrt(Math.Pow(längeX, 2)+ Math.Pow(längeY. 2));
        }
    } // class
} // namespace