using System;
namespace Geometrie.Models
{

    /// <summary>
    /// Interface d'une forme dans un repère à deux dimensions
    /// </summary>
    internal interface IForme
    {
        /// <summary>
        /// Calcul de périmètre de la IForme
        /// </summary>
        /// <returns>le périmètre</returns>
        double CalculerPerimetre();

        /// <summary>
        /// Calcul de l'air de la IForme
        /// </summary>
        /// <returns>l'air</returns>
        double CalculerAire();
    }
}
