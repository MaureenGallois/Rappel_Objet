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
            var p3 = new Point(10, 4);
            var p4 = new Point(3, 6);

            Cercle c = new Cercle(p, 4);


            var poly = new Polygone(p, p2, p3, p4);
            System.Console.WriteLine(poly.CalculerPerimetre());



            foreach (var item in poly)
            {
                System.Console.WriteLine(item);
            }



            for (int i = 0; i<poly.Count; i++)
            {
                System.Console.WriteLine(poly[i].ToString());
            }
        }
    }
}
