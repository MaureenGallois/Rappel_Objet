using System;
namespace Geometrie.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Cercle : IForme
    {
        public Point Centre { get; set; }
        public double Rayon { get; set; }

        public Cercle(Point centre, double rayon)
        {
            if (centre == null)
                throw new Exception("Le centre ne peut pas petre null");
            Centre = centre;
            Rayon = rayon;
        }

        public double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }

        public double CalculerPerimetre()
        {
            return Math.PI * Rayon * 2;
        }
    }
}
