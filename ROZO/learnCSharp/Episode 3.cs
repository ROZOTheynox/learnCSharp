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
            #region Episode 3
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
            #endregion

            #region Episode 4
            int[] chiffres = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(chiffres[2]);
            Console.WriteLine(chiffres[chiffres.Count() -1]);


            string[] weekend = new string[2];
            weekend[0] = "Samedi";
            weekend[1] = "Dimanche";
            Console.WriteLine(weekend[0]);


            List<string> matieres = new List<string> ();
            matieres.Add("Maths");
            matieres.Add("EPS");
            matieres.Add("Français");
            matieres.Remove("Français");
            matieres.Add("Technologie");
            Console.WriteLine(matieres[2]);
            Console.WriteLine(matieres.IndexOf("Maths"));






            #endregion


        }
    }
}
 