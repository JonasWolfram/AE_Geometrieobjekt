using System;

namespace AE_Geometrieobjekt
{
    public class Punkt
    {
        // Attribute
        // Achtung: " x-Wert" wie
        // im UML Diagramm wird
        // als Differenz betrachtet
        // Umbenennung nach "xWert"
        private double xWert;
        private double yWert;

        public Punkt()
        {

        }
        public Punkt(double xWert, double yWert)
        {
            this.xWert = xWert;
            this.yWert = yWert;
        }
        public double GetX()
        {
            return this.xWert;
        }
        public double GetY()
        {
            return this.yWert;
        }
    } // class
} // namespace