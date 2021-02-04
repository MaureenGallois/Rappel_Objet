using System;
using Geometrie.Models;

namespace Geometrie.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(3, 4);
            var p2 = new Point(5, 7); // Revient à faire Point p2 = new Point(5, 7); car cela permet de racoussir

            var c = new Cercle(p, 4);

            System.Console.WriteLine(c.CalculerPerimetre());
        }
    }
}
