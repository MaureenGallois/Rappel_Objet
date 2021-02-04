using System;

namespace Geometrie.Models
{
    /// <summary>
    /// Représente un point dans un repère à deux dimensions
    /// </summary>
    public class Point
    {
        #region Propriétés
        private int x;

        /// <summary>
        /// Abscisse du point
        /// </summary>
        public int X
        {
            get { return x;  }
            private set { x = value; }
        }

        /// en version courte (mais qui rée la même chose à la compilation)
        /// <summary>
        /// Ordonnnée du point
        /// </summary>
        public int Y { get; set; }
        #endregion

        /// <summary>
        /// Constructeur de point
        /// </summary>
        /// <param name="abs">Abscisse du point à créer</param>
        /// <param name="ord">Ordonnée du point à créer</param>
        public Point(int abs, int ord)
        {
            X = abs; //en c# le this. est sous entendu
            Y = ord;
        }

        public double CalculerDistance(Point autrePoint)
        {
            return Math.Sqrt(
                Math.Pow(X - autrePoint.X, 2)
                +
                Math.Pow(Y - autrePoint.Y, 2)
            );
        }

        public override string ToString()
        {
            //return "(" + X + "," + Y + ")"; //pour avoir (3,4) Mais pas bien pour la mémoire
            return $"({X}, {Y})"; //Fait la même chose et c'est mieux pour la mémoire
        }

    }
}
