using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public class Outils
    {
        private int unNombre = 12;
        private static int nombres = 5012;
        public Outils()
        {
            Console.WriteLine("Je suis instanciée");
        }

        public static void staticMethod()
        {
            Console.WriteLine(nombres);
        }

        public void myMethod ()
        {
            Console.WriteLine("Méthode");
        }

        private static int GetNombre()
        {
            return nombres;
        }




    }
}