using System;
using System.Collections;
using System.Collections.Generic;
namespace Geometrie.Models
{
    public class Polygone : IForme, IEnumerable<Point>
    { 

        private List<Point> lesPoints;

        public int Count
        {
            get { return lesPoints.Count; }
        }

        //indexeur (pour le for en général)
        public Point this[int index]
        {
            get { return lesPoints[index]; }
        }

        public double CalculerAire()
        {
            throw new NotImplementedException();
        }

        public double CalculerPerimetre()
        {
            double peri = 0;
            for (int i= 0; i<lesPoints.Count-1; i++)
            {
                peri += lesPoints[i].CalculerDistance(lesPoints[i + 1]);
            }
            peri += lesPoints[0].CalculerDistance(lesPoints[lesPoints.Count-1]);
            return peri;
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return lesPoints.GetEnumerator();
        }

        //Cette méthode n'est là que pour des raisons de compatibilité avec de vieux objets
        //on peut juste retourner le résultat de la méthode d'au dessus
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Polygone(Point a, Point b, Point c, params Point[] autresPoints)
        {
            lesPoints = new List<Point>();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);
            lesPoints.AddRange(autresPoints);

        }
    }
}
