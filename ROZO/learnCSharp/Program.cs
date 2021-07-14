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

            //Une procédure qui demande un prenom et qui l'écrit
            void direBonjour(string prenom)
            {
                Console.WriteLine("\t---------------");
                Console.WriteLine("\tBonjour " + prenom);
                Console.WriteLine("\t---------------");
            }

            //Une fonction qui appelle trois fois la procédure direBonjour
            void direBonjourPlusieursFois(string prenom)
            {
                direBonjour(prenom);
                direBonjour(prenom);
                direBonjour(prenom);
            }

            //Une ligne de code qui rempli le paramètre de la procédure direBonjour
            direBonjourPlusieursFois("Alexis");
            
            //Une fonction qui calcule l'aire d'un rectangle avec le paramètre longueur et le paramètre largeur qui sont des entiers. Mais comme c'est une fonction qui renvoie quelque chose il faut preciser le format qu'elle renvoie
            string aireRectangle(int longueur, int largeur)
            {
                int aire = longueur * largeur;
                return "L'aire du rectangle est de " + aire;
            }

            //Une ligne de code qui écrit une fonction en précisant les paramètres
            Console.WriteLine(aireRectangle(5, 90));

            //Si on ne veut pas mettre un paramètre on peut ne pas en mettre
            #endregion

            #region Episode 4
            Title("Episode 4, Le tablal et les listes");

            //Un tableau de format int qui contient les chiffres
            int[] chiffres = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Une ligne de code qui écrit l'élément 2
            Console.WriteLine(chiffres[2]);
            //Une ligne de code qui écrit l'élément -1 en partant de la fin
            Console.WriteLine(chiffres[chiffres.Count() -1]);

            //Un tableau avec une autre syntaxe
            string[] weekend = new string[2];
            weekend[0] = "Samedi";
            weekend[1] = "Dimanche";
            Console.WriteLine(weekend[0]);


            //Une liste au format string qui contient les cours de la journée
            List<string> cours = new List<string> { "Anglais", "Maths", "Français" };
            //Une ligne de code qui premet d'afficher le numéro correspondant à l'élément "Maths"
            Console.WriteLine(cours.IndexOf("Maths"));

            //Une liste au format string qui ne contient rien et à laquelle on rajoute des choses et on en supprime petit a petit
            List<string> matieres = new List<string> ();
            matieres.Add("Maths");
            matieres.Add("EPS");
            matieres.Add("Français");
            matieres.Remove("Français");
            matieres.Add("Technologie");
            Console.WriteLine(matieres[2]);


            //Une liste peut être modifié contrairement à un tablea
            //Le premier élément d'une liste ou d'un tableau est l'élément 0 et non l'élément 1
            #endregion

            #region Episode 5
            Title("Episode 5, Les boucles");
            //Une liste avec les jours de la semaine
            List<string> weekList = new List<string> {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};

            //Une boucle qui définit la variable "i" à 1. Elle dit que tant que "i" est inférieur à 5 elle augmente de 1 en affichant un message et en recommancant
            for (int i = 1; i <= 5; i += 1)
            {
                Console.WriteLine("Message" + i);
            }

            //Une boucle qui utilise la liste "weekList". Elle définit la variable i à 0 car cela concerne une liste et dit que tant que i est inférieur au nombre d'éléments dans la liste "weekList" elle augmente de 1 affiche un message et recommence
            for (int i = 0; i < weekList.Count; i += 1)
            {
                Console.WriteLine("Le " + weekList[i] + " est le jour numéro " + i);
            }

            //Une ligne de code qui incite à appuyer sur "A" puis une boucle while qui veut dire que si la touche A n'a pas été appuyé suite au précédant message le message se réaffiche.
            Console.WriteLine("Appuyez sur la touche A pour continuer");
            while (Console.ReadKey(true).Key != ConsoleKey.A)
            {
                Console.WriteLine("Appuyez sur la touche A pour continuer");
            }

            //La continuation si la boucle while n'a pas été déclenché
            Console.WriteLine("Vous avez appuyer sur la touche A");
            Console.ReadKey(true);

            //Une boucle foreach qui va parcourir forcément tous les éléments d'une liste ou d'un tableau et qui va afficher toute la liste dans le message qu'elle contient.
            foreach (string aDay in weekList)
            {
                Console.WriteLine(aDay + " Le nombre de caractères dans ce jour est " + aDay.Length);
            }

            //Boucle for qui repète quelque chose
            //Boucle while = tant que
            //Boucle foreach = va parcourir tous les éléments d'une liste 
            #endregion

            #region Episode 6
            Title("Episode 6, Les dictionnaires");
            //Une déclaration de dictionnaire avec un entier et une chaine de caractères
            Dictionary<int, string> unDeuxTrois = new Dictionary<int, string>
            {
                {1, "Un" },
                {2, "Deux" },
                {3, "Trois" }
            };
            //Un message qui affiche l'élément 1 du dictionnaire
            Console.WriteLine(unDeuxTrois[1]);

            //Une boucle foreach qui va afficher toutes les valeurs du dictionnaire "unDeuxTrois".
            foreach(KeyValuePair<int, string> pair in unDeuxTrois)
            {
                Console.WriteLine(pair.Value);
            }

            //Un dictionnaire qui contient le pseudos corresondant au noms de la team
            Dictionary<string, string> firstName = new Dictionary<string, string>
            {
                { "ROZO", "Alexis"},
                {"Theynox", "Théandre" },
                {"RoiU", "Ulysse" }
            };

            //Un message qui affiche le prenom de Theynoxs
            Console.WriteLine(firstName["Theynox"]);

            //La clé dan un dictionnaire est le premier élément 
            //La valeur dans un dictionnaire est le second élément
            #endregion

            #region Episode 7
            Title("Episode 7, Les classes");
            //Voir classe Personne.cs
            //Importation de la classe Personne et transformation en variable
            Personne unePersonne;
            //Appel de la fonction Personne avec les paramètres
            unePersonne = new Personne("Sudraud", "Alexis", "Masculin", 11) ;
            //Message indiquant toutes les infos que l'ont a entrées avant
            Console.WriteLine(unePersonne.infosPersonne());
            //Augmentation de 1 de l'age
            unePersonne.age ++;
            //Message indiquant toutes les infos avec la modification qui a été éfectuée avant
            Console.WriteLine(unePersonne.age);
            #endregion

            #region Episode 8
            Title("Episode 9, Les trucs statiques");
            //Voir classe Outils.cs
            //Création d'une variable qui importe la classe Outils
            Outils outils = new Outils();
            //Appel de la fonction myMetod
            outils.myMethod();
            //Appel de la fonction staticMethod
            Outils.staticMethod();
            #endregion

            #region Episode 9
            Title("Episode 9, L'heritage");
            //Voir classes : Animal.cs, Chien.cs, Chat.cs
            //Création d'une variable qui importe la classe Chien
            Chien chien = new Chien("Yuki");
            //Création d'une variable qui importe la classe Chat
            Chat chat = new Chat("La Chatte à Mia Khalifa");
            //Appel de la fonction Aboyer
            chien.Aboyer();
            //Appel de la fonction Miauler
            chat.Miauler();
            //Changement de la fonction SetFaim des chiens
            chien.SetFaim(true);
            //Changement de la fonction SetFaim des chats
            chat.SetFaim(true);
            //Appel de la fonction Manger des chiens
            chien.Manger();
            //Appel de la fonction Manger des chats
            chat.Manger();
            #endregion

            #region Episode 10
            Title("Episode 10, La visibilité et la portée des variables");
            //Une variable dans une méthode ne peut pas être utilisée en dehors de la méthode
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

            #region Episode 12
            Title("Episode 12, Conversion de type de données");

            int a = 2147483647;
            long b = 93212312365453587;
            b =a;


            double c = 2.4;
            Console.WriteLine(c);
            Console.WriteLine((int)c);

            int trenteDouze = Convert.ToInt32("3012");

            if (int.TryParse("trente-douze", out trenteDouze))
            {
                Console.WriteLine("Le nombre " + trenteDouze + "à été converti");
            }
            else
            {
                Console.WriteLine("Conversion impossible");
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
 