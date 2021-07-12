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
            Title("Episode 3, Methodes");
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
            Title("Episode 4, Le tablal et les listes");
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

            #region Episode 5
            Title("Episode 5, Les boucles");
            List<string> weekList = new List<string> {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};

            for (int i = 1; i <= 5; i += 1)
            {
                Console.WriteLine("Message" + i);
            }


            for (int i = 0; i < weekList.Count; i++)
            {
                Console.WriteLine("Le " + weekList[i] + " est le jour numéro " + i);
            }


            Console.WriteLine("Appuyez sur la touche A pour continuer");
            while (Console.ReadKey(true).Key != ConsoleKey.A)
            {
                Console.WriteLine("Appuyez sur la touche A pour continuer");
            }

            Console.WriteLine("Vous avez appuyer sur la touche A");
            Console.ReadKey(true);


            foreach (string aDay in weekList)
            {
                Console.WriteLine(aDay + " Le nombre de caractères dans ce jour est " + aDay.Length);
            }
            #endregion

            #region Episode 6
            Title("Episode 6, Les dictionnaires");
            Dictionary<int, string> unDeuxTrois = new Dictionary<int, string>
            {
                {1, "Un" },
                {2, "Deux" },
                {3, "Trois" }
            };
            Console.WriteLine(unDeuxTrois[1]);

            foreach(KeyValuePair<int, string> pair in unDeuxTrois)
            {
                Console.WriteLine(pair.Value);
            }

            Dictionary<string, string> firstName = new Dictionary<string, string>
            {
                { "ROZO", "Alexis"},
                {"Theynox", "Théandre" },
                {"RoiU", "Ulysse" }
            };

            Console.WriteLine(firstName["Theynox"]);
            #endregion

            #region Episode 7
            Title("Episode 7, Les classes");
            //Voir classe Personne.cs
            Personne unePersonne;
            unePersonne = new Personne("Sudraud", "Alexis", "Masculin", 11) ;
            Console.WriteLine(unePersonne.infosPersonne());
            unePersonne.age ++;
            Console.WriteLine(unePersonne.age);
            #endregion

            #region Episode 8
            Title("Episode 9, Les trucs statiques");
            //Voir classe Outils.cs
            Outils outils = new Outils();
            outils.myMethod();
            Outils.staticMethod();
            #endregion

            #region Episode 9
            Title("Episode 9, L'heritage");
            //Voir classes : Animal.cs, Chien.cs, Chat.cs
            Chien chien = new Chien("Yuki");
            Chat chat = new Chat("La Chatte à Mia Khalifa");
            chien.Aboyer();
            chat.Miauler();
            chien.SetFaim(true);
            chat.SetFaim(true);
            chien.Manger();
            chat.Manger();
            #endregion

            #region Episode 10
            Title("Episode 10, La visibilité et la portée des variables");
            //Pendant cet épisode il a juste expliquer des trucs
            #endregion

            #region Episode 11
            Title("Episode 11, Les exceptions");
            try
            {
                Console.WriteLine("Entrez un nombre : ");
                int readNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("100 / {0} = {1} ", readNumber, 100 / readNumber);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divsion par zéro impossible");
            }
            catch(FormatException)
            {
                Console.WriteLine("Veuillez entrer un entier");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Valeure trop grande ou trop petite");
            }
            finally
            {
                Console.WriteLine("Vous avez terminé l'épisode");
            }


            #endregion


            //Methode Title () pour se reperer dans la console
            void Title(string text)
            {
                Console.WriteLine("-----------------------------------" + text + "-----------------------------------");
            
            }
        }
    }
}
 