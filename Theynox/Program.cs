using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_test_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Episode 1
            //ep 1

            Title("Episode 1");
            ls();

            //calcul 

            #region calcul d'une moyenne
            Title("calcul d'une moyenne");
            int note = 20;
            int moyenne = 0;
            moyenne = (note + 8) / 2;
            Console.WriteLine(moyenne);
            #endregion

            //String text

            #region écrire dans la console avec du string
            Title("écrire dans la console avec du string");
            string chaine = "Salut ";
            string chaine2 = "beaugosse !";
            Console.WriteLine(chaine + chaine2);
            #endregion

            //String répertoire

            #region donner un répertoire en String
            Title("donner un répertoire en String");
            string devrepertory = "D:\\Developpement 2\\VS dev\\Premier test de Csharp";
            Console.WriteLine(devrepertory);

            #endregion
            #endregion

            #region Episode 2
            ls();
            Title("Episode 2");
            ls();


            //conditions (if)

            #region les conditions 
            Title("les conditions");
            int age = 16;

            if (age >= 18)
            {
                Console.WriteLine("Tu est majeur va acheter des mangas avec t'on passe culture !");
            }
            else
            // ici else remplace if (age < 18)
            {
                Console.WriteLine("Tu n'est pas majeur dommage le passe culture c'est pas pour maintenant");
            }

            #endregion

            #region tout cela peut être remplacer par un boolean
            //int age = 16;
            //bool estMajeur = (age >= 18);
            //if(estMajeur)
            //{
            //Console.WriteLine("Tu est majeur va acheter des mangas avec t'on passe culture !");
            //}
            //if(!estMajeur)
            //{
            //Console.WriteLine("Tu n'est pas majeur dommage le passe culture c'est pas pour maintenant");
            //}

            //toujours condition if mais on fait comme un login
            #endregion

            ls();

            #region on fait comme un login avec des conditions :)
            Title("on fait comme un login avec des conditions");
            string login = "Theynox";
            string password = "1234";

            if (login == "Theynox" && password == "1234" || password == "TheynoxCode")
            {
                Console.WriteLine("Tu est connecté ! Tu m'as hack ?");
            }
            else
            {
                Console.WriteLine("Oh tu t'es trompé, recommence !");
            }
            #endregion

            //encore l'age avec if ;)

            #region on test le else if
            Title("on test le else if");
            int age1 = 18;

            if (age1 == 18)
                //ici on peut retiré les accolades {}
                Console.WriteLine("vous avez 18 ans");
            else if (age1 == 16)
                //ici aussi
                Console.WriteLine("vous avez 16 ans");
            #endregion

            //allez pour une fois teston le switch

            #region Switch test
            Title("Switch test");
            ls();
            string mois = "Juillet";
            switch (mois)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'autonne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;
            }
            #endregion

            #endregion

            #region Episode 3
            ls();
            Title("Episode 3");
            ls();

            //faire des répétitions sans écrire 1000lignes de codes
            #region répétitions
            Title("répétitions");
            aimelecode("Theynox");
            void aimelecode(string prenom)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(prenom + " aime le code le code :)");
                Console.WriteLine("---------------------------");
            }
            ls();

            #endregion

            #region Calculer l'aire d'un rectangle
            Title("Calculer l'aire d'un rectangle");
            Console.WriteLine(AireRectangle(15, 6));
            string AireRectangle(int longueur, int largeur)
            {
                int aire = longueur * largeur;
                return "L'aire du rectangle est de : " + aire;
            }

            #endregion

            #endregion

            #region Episode 4
            //ep 4
            ls();
            Title("Episode 4");
            ls();

            //on apprend les tableaux !

            #region Tableau des nombres premiers 
            Title("Tableau des nombres premiers");
            int[] nombrePremiers = new int[] { 7, 2, 8, 1, 12, 30, 14 };
            Console.WriteLine(nombrePremiers[0]); // 7
            Console.WriteLine(nombrePremiers[4]); // 1
            Console.WriteLine(nombrePremiers[nombrePremiers.Count() - 1]); // 14
            //je peut le simplifier en mettant 
            //Console.WriteLine(nombrePremiers[7]);
            //mais bon vaut mieux apprendre plus d'info :)
            //Console.WriteLine(nombrePremiers[10]); Erreur car je sor de ma liste
            Console.ReadKey(true);
            #endregion

            #region Tableau des jours du week-end
            Title("Tableau des jours du week-end");
            string[] weekend = new string[2];
            weekend[0] = "Samedi";
            weekend[1] = "Dimanche";
            Console.WriteLine(weekend[0]);
            Console.ReadKey(true);
            #endregion

            //on fait une liste !
            #region Liste des matières
            Title("Liste des matières");
            List<string> matiere = new List<string>();
            matiere.Add("Anglais");
            matiere.Add("Français");
            matiere.Add("Maths");
            Console.WriteLine(matiere[0]);
            Console.WriteLine(matiere[2]);
            #endregion

            #endregion

            #region Episode 5
            ls();
            Title("Episode 5");
            ls();

            List<string> jourListe = new List<string> { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            string[] joursTableau = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            #region La boucle for
            Title ("la boucle for");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Message n° " + i);
            }

            Console.ReadKey(true);

            ls();
            for (int i = 0; i < jourListe.Count; i++)
            {
                Console.WriteLine(jourListe[i]);
            }

            Console.ReadKey(true);

            #endregion

            #region La boucle while
            Title("La boucle while");
            Console.WriteLine("Appuyez sur la touche 'A'");

            while (Console.ReadKey(true).Key != ConsoleKey.A)
            {
                Console.WriteLine("Appuyez sur la touche 'A'");
            }

            Console.WriteLine("Vous avez appuyez sur la touche 'A'");
            Console.ReadKey(true);
            #endregion

            #region La boucle foreach
            Title("La boucle foreach");
            foreach (string unJour in jourListe)
            {
                Console.WriteLine(unJour);
            }
            #endregion

            #endregion

            #region Episode 6
            ls();
            Title("Episode 6");
            ls();

            #region Chiffres
            Title("Dictionaire des chiffres (50% int 50%string)");
            Dictionary<int, string> chiffres = new Dictionary<int, string>()
            {
                { 1, "un"},
                { 2, "deux"},
                { 3, "trois"}
            };
            foreach (KeyValuePair<int, string> pair in chiffres)
            {
                Console.WriteLine(pair.Value + " - " + pair.Key);
            }

            Console.ReadKey(true);
            #endregion

            #region Last Versions
            Title("Dictionaire des versions(100% string)");

            Dictionary<string, string> lastVersions = new Dictionary<string, string>()
            {
                { "Minecraft", "1.17.1"},
                { "Visual studio", "2019"},
                { "Windows", "10"}
            };
            Console.WriteLine(lastVersions["Minecraft"]);
            #endregion

            #endregion

            #region Episode 7
            ls();
            Title("Episode 7");
            ls();
            Personne unePersonne;
            unePersonne = new Personne("Bg", "Theynox", 12);

            unePersonne.age = 12;
            Console.WriteLine(unePersonne.Info());


            #endregion

            #region Episode 8
            ls();
            Title("Episode 8");
            ls();

            Outils.StaticMethod();









            #endregion

            #region Episode 9
            ls();
            Title("Episode 9");
            ls();

            //je fais pas car il as pas expliquer grand chose










            #endregion

            #region Epsiode 10
            ls();
            Title("Episode 10");
            ls();
            //je vais creer une nouvelle classe pour importer 
            //(c'est pour moins de bordel)
            //enfaite si tu veux va voir Form1.cs :)

            #endregion

            #region Episode 11
            ls();
            Title("Episode 11");
            ls();

            try
            {
                Console.Write("Entrez un nombre : ");
                int nombre = int.Parse(Console.ReadLine());
                Console.WriteLine("100 / {0} = {1}", nombre, 100 / nombre );
            }
            catch (DivideByZeroException)
            {
                Console.Write("Erreur : Division par 0 impssible ...");
            }

            catch(OverflowException)
            {
                Console.WriteLine("Erreur : Le nombre est trop grand ou trop petit ...");
            }
            
            catch(FormatException)
            {
                Console.WriteLine("Erreur : T'on caracthère n'est pas = a un nombre");
            }
            finally
            {

                Console.WriteLine("-------------------------------TERMINÉ-------------------------------");
            }








            #endregion

            #region Episode 12
            ls();
            Title("Episode 12");
            ls();

            int a = 2147483647;
            long b = 9223372036854775807;

            b = a;
            Console.WriteLine(b);
            
            double c = 2.4;
            Console.WriteLine(c);

            int unNombre = Convert.ToInt32("55");
            Console.WriteLine(unNombre);

            if (int.TryParse("123", out unNombre))
            {
                Console.WriteLine("La conversion a été effectué : " + unNombre);
            }
            else
            {
                Console.WriteLine("Conversion impossible !");
            }




            #endregion

            #region Epîsode 13
            ls();
            Title("Episode 13");
            ls();

            //cette fois je fais une nouvelle classe

            Episode13.Ep13();









            #endregion







            void Title(string text)
            {
                Console.WriteLine("-----------------------------------" + text + "-----------------------------------");
            }

            void ls()
            {
                Console.WriteLine("");
            }
        }
    }
}