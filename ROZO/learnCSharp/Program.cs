using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            void direBonjour(string prenom)
            {
                Console.WriteLine("\t---------------");
                Console.WriteLine("\tBonjour " + prenom);
                Console.WriteLine("\t---------------");
            }

            void direBonjourPlusieursFois(string prenom)
            {
                direBonjour(prenom);
                direBonjour(prenom);
                direBonjour(prenom);
            }

            direBonjourPlusieursFois("Alexis");

            string aireRectangle(int longueur, int largeur)
            {
                int aire = longueur * largeur;
                return "L'aire du rectangle est de " + aire;
            }

            Console.WriteLine(aireRectangle(5, 90));
        }
    }
}
 