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
            set { x = value; }
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
        /// <param name="abs"></param>
        /// <param name="ord"></param>
        public Point(int abs, int ord)
        {
            X = abs; //en c# le this. est sous entendu
            Y = ord;
        }

    }
}
