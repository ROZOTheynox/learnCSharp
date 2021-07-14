using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public class Outils
    {
        //Création d'une variable non statique 
        private int unNombre = 12;
        //Création d'une vraiable statique
        private static int nombres = 5012;
        //Procédure qui explique qu'elle est instanciée car elle n'est pas statique
        public Outils()
        {
            Console.WriteLine("Je suis instanciée");
        }
        //Procédure statique qui a besoin d'une variable statique
        public static void staticMethod()
        {
            Console.WriteLine(nombres);
        }

        //Procédure non statique 
        public void myMethod ()
        {
            Console.WriteLine("Méthode");
        }

        //Fonction statique qui retourne une variable statique
        private static int GetNombre()
        {
            return nombres;
        }




    }
}