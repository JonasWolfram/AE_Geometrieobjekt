using System;

namespace AE_Geometrieobjekt
{
    public class Kreis
    {
        private double radius;
        private Punkt mittelpunkt;

        // Konstruktoren
        public Kreis()
        {

        }
        public Kreis(double radius, Punkt mittelpunkt)
        {
            this.radius = radius;
            this.mittelpunkt = mittelpunkt;
        }

        // Methoden
        public double InhaltBerechnen()
        {
            return Math.Pow(this.radius, 2) + Math.PI;
        } 

        public double UmfangBerechnen()
        {
            return Math.PI * this.radius * 2;
        }
    } // class
} // namespace
