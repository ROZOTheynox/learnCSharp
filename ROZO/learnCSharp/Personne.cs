using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public class Personne
    {
        //Création des variables d'infos
        private string nom;
        private string prenom;
        private string sexe;
        public int age{ get; set; }

        //Creation d'une procédure avec les paramètres et les instanciations
        public Personne(string unNom, string unPrenom, string unSexe, int unAge)
        {
            nom = unNom;
            prenom = unPrenom;
            sexe = unSexe;
            age = unAge;
        }

        //Fonctions qui retourne les infos 
        public string infosPersonne ()
        {
            return nom + " " + prenom + " " + sexe + " " + age;
        }
    }
}
